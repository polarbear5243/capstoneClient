S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9346
Date: 2017-04-14 03:26:05+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9346, uid 5000)

Register Information
r0   = 0xbead2eec, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb28113f1, r5   = 0xb7c25568
r6   = 0xb7de4850, r7   = 0xbead3230
r8   = 0x800f85c6, r9   = 0xb5f14708
r10  = 0xb7de16c0, fp   = 0x00000000
ip   = 0x800f85c6, sp   = 0xbead3218
lr   = 0xbead2eec, pc   = 0xb2811406
cpsr = 0x600f0030

Memory Information
MemTotal:   987012 KB
MemFree:    144440 KB
Buffers:     48112 KB
Cached:     324688 KB
VmPeak:     136288 KB
VmSize:     135140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30692 KB
VmRSS:       29884 KB
VmData:      47028 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35828 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9346 TID = 9346
9346 9349 9406 9407 9425 

Maps Information
af22e000 afa2d000 rw-p [stack:9425]
b069f000 b06b0000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f18000 b0f1d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13ad000 b13b5000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13c7000 b1bc6000 rw-p [stack:9407]
b1bc6000 b1bc7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd7000 b1beb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bff000 b1c00000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c10000 b1c13000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c24000 b1c25000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c35000 b1c37000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c47000 b1c49000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c59000 b1c69000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c79000 b1c85000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c97000 b2496000 rw-p [stack:9406]
b27c7000 b27ce000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27e1000 b27e7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f7000 b281f000 r-xp /opt/usr/apps/org.example.client/bin/client
b2978000 b2a5b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a92000 b2aba000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2acc000 b32cb000 rw-p [stack:9349]
b32cb000 b32cd000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32dd000 b32e7000 r-xp /lib/libnss_files-2.20-2014.11.so
b32f8000 b3301000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3312000 b3323000 r-xp /lib/libnsl-2.20-2014.11.so
b3336000 b333c000 r-xp /lib/libnss_compat-2.20-2014.11.so
b334d000 b334e000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3376000 b337d000 r-xp /usr/lib/libminizip.so.1.0.0
b338d000 b3392000 r-xp /usr/lib/libstorage.so.0.1
b33a2000 b3401000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3417000 b342b000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b343b000 b347f000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b348f000 b3497000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34a7000 b34d7000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ea000 b35a3000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35b7000 b360a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b361b000 b3636000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3646000 b3707000 r-xp /usr/lib/libprotobuf.so.9.0.1
b371a000 b372a000 r-xp /usr/lib/libefl-assist.so.0.1.0
b373a000 b3747000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3758000 b375f000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b376f000 b37b0000 r-xp /usr/lib/libmdm.so.1.2.12
b37c0000 b37c8000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37d7000 b37e7000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3808000 b3868000 r-xp /usr/lib/libasound.so.2.0.0
b387a000 b387d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b388d000 b3890000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38a0000 b38a5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38b5000 b38b6000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38c6000 b38d1000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38e5000 b38ec000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38fc000 b3902000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3912000 b3917000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3927000 b3942000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3952000 b3959000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3969000 b396c000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b397d000 b39ab000 r-xp /usr/lib/libidn.so.11.5.44
b39bb000 b39d1000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e2000 b39ec000 r-xp /usr/lib/libcares.so.2.1.0
b39fc000 b3a06000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a16000 b3a18000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a28000 b3a29000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a39000 b3a3d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a4e000 b3a76000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a87000 b3ab0000 r-xp /usr/lib/libturbojpeg.so
b3ad0000 b3ad6000 r-xp /usr/lib/libgif.so.4.1.6
b3ae6000 b3b2c000 r-xp /usr/lib/libcurl.so.4.3.0
b3b3d000 b3b5e000 r-xp /usr/lib/libexif.so.12.3.3
b3b79000 b3b8e000 r-xp /usr/lib/libtts.so
b3b9f000 b3ba7000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bb7000 b3c7d000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c9d000 b3d95000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db4000 b3e82000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e99000 b3e9b000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eab000 b3eb1000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec1000 b3ee4000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ef5000 b3ef7000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f07000 b3f09000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f1a000 b3f1f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f36000 b3f38000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f48000 b3f4f000 r-xp /usr/lib/libsensord-share.so
b3f5f000 b3f77000 r-xp /usr/lib/libsensor.so.1.1.0
b3f88000 b3f8b000 r-xp /usr/lib/libXv.so.1.0.0
b3f9b000 b3fa0000 r-xp /usr/lib/libutilX.so.1.1.0
b3fb0000 b3fb5000 r-xp /usr/lib/libappcore-common.so.1.1
b3fc5000 b3fcc000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fdf000 b3fe3000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff4000 b40d2000 r-xp /usr/lib/libCOREGL.so.4.0
b40f2000 b40f5000 r-xp /usr/lib/libuuid.so.1.3.0
b4105000 b411c000 r-xp /usr/lib/libblkid.so.1.1.0
b412d000 b412f000 r-xp /usr/lib/libXau.so.6.0.0
b413f000 b4186000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4198000 b419e000 r-xp /usr/lib/libjson-c.so.2.0.1
b41af000 b41b3000 r-xp /usr/lib/libogg.so.0.7.1
b41c3000 b41e5000 r-xp /usr/lib/libvorbis.so.0.4.3
b41f5000 b42d9000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42f5000 b42f8000 r-xp /usr/lib/libEGL.so.1.4
b4309000 b430f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b431f000 b4321000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4331000 b433e000 r-xp /usr/lib/libGLESv2.so.2.0
b434f000 b43b1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43c6000 b43de000 r-xp /usr/lib/libmount.so.1.1.0
b43f0000 b4404000 r-xp /usr/lib/libxcb.so.1.1.0
b4414000 b441b000 r-xp /lib/libcrypt-2.20-2014.11.so
b4453000 b4455000 r-xp /usr/lib/libiri.so
b4465000 b4470000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4481000 b44b7000 r-xp /usr/lib/libpulse.so.0.16.2
b44c8000 b450b000 r-xp /usr/lib/libsndfile.so.1.0.25
b4520000 b4535000 r-xp /lib/libexpat.so.1.5.2
b4547000 b4605000 r-xp /usr/lib/libcairo.so.2.11200.14
b4619000 b4621000 r-xp /usr/lib/libdrm.so.2.4.0
b4631000 b4634000 r-xp /usr/lib/libdri2.so.0.0.0
b4644000 b4692000 r-xp /usr/lib/libssl.so.1.0.0
b46a7000 b46b3000 r-xp /usr/lib/libeeze.so.1.13.0
b46c4000 b46cd000 r-xp /usr/lib/libethumb.so.1.13.0
b46dd000 b46e0000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46f0000 b48a7000 r-xp /usr/lib/libcrypto.so.1.0.0
b5692000 b569b000 r-xp /usr/lib/libXi.so.6.1.0
b56ab000 b56ad000 r-xp /usr/lib/libXgesture.so.7.0.0
b56bd000 b56c1000 r-xp /usr/lib/libXtst.so.6.1.0
b56d1000 b56d7000 r-xp /usr/lib/libXrender.so.1.3.0
b56e7000 b56ed000 r-xp /usr/lib/libXrandr.so.2.2.0
b56fd000 b56ff000 r-xp /usr/lib/libXinerama.so.1.0.0
b5710000 b5713000 r-xp /usr/lib/libXfixes.so.3.1.0
b5723000 b572e000 r-xp /usr/lib/libXext.so.6.4.0
b573e000 b5740000 r-xp /usr/lib/libXdamage.so.1.1.0
b5750000 b5752000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5762000 b5844000 r-xp /usr/lib/libX11.so.6.3.0
b5858000 b585f000 r-xp /usr/lib/libXcursor.so.1.0.2
b586f000 b5887000 r-xp /usr/lib/libudev.so.1.6.0
b5889000 b588c000 r-xp /lib/libattr.so.1.1.0
b589c000 b58bc000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58bd000 b58c2000 r-xp /usr/lib/libffi.so.6.0.2
b58d3000 b58eb000 r-xp /lib/libz.so.1.2.8
b58fb000 b58fd000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b590d000 b59e2000 r-xp /usr/lib/libxml2.so.2.9.2
b59f7000 b5a92000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aae000 b5ab1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac1000 b5ada000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aeb000 b5afc000 r-xp /lib/libresolv-2.20-2014.11.so
b5b10000 b5b8a000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b9f000 b5ba1000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb1000 b5bb8000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc8000 b5bd2000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be3000 b5bfb000 r-xp /usr/lib/libpng12.so.0.50.0
b5c0c000 b5c2f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c50000 b5c64000 r-xp /usr/lib/libector.so.1.13.0
b5c75000 b5c8d000 r-xp /usr/lib/liblua-5.1.so
b5c9e000 b5cf5000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d09000 b5d31000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d42000 b5d55000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d66000 b5da0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db1000 b5dbf000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dcf000 b5dd7000 r-xp /usr/lib/libtbm.so.1.0.0
b5de7000 b5df4000 r-xp /usr/lib/libeio.so.1.13.0
b5e04000 b5e06000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e16000 b5e1b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e2b000 b5e42000 r-xp /usr/lib/libefreet.so.1.13.0
b5e54000 b5e74000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e84000 b5ea4000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ea6000 b5eac000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ebc000 b5ecd000 r-xp /usr/lib/libemotion.so.1.13.0
b5ede000 b5ee5000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef5000 b5f04000 r-xp /usr/lib/libeo.so.1.13.0
b5f15000 b5f27000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f38000 b5f3d000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f4d000 b5f66000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f76000 b5f93000 r-xp /usr/lib/libeet.so.1.13.0
b5fac000 b5ff4000 r-xp /usr/lib/libeina.so.1.13.0
b6005000 b6015000 r-xp /usr/lib/libefl.so.1.13.0
b6026000 b610b000 r-xp /usr/lib/libicuuc.so.51.1
b6128000 b6268000 r-xp /usr/lib/libicui18n.so.51.1
b627f000 b62b7000 r-xp /usr/lib/libecore_x.so.1.13.0
b62c9000 b62cc000 r-xp /lib/libcap.so.2.21
b62dc000 b6305000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6316000 b631d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b632f000 b6366000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6377000 b6462000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6475000 b64ee000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6500000 b6505000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6515000 b651f000 r-xp /usr/lib/libvconf.so.0.2.45
b652f000 b6531000 r-xp /usr/lib/libvasum.so.0.3.1
b6541000 b6543000 r-xp /usr/lib/libttrace.so.1.1
b6553000 b6556000 r-xp /usr/lib/libiniparser.so.0
b6566000 b658c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b659c000 b65a1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b2000 b65c9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65da000 b6645000 r-xp /lib/libm-2.20-2014.11.so
b6656000 b665c000 r-xp /lib/librt-2.20-2014.11.so
b666d000 b667a000 r-xp /usr/lib/libunwind.so.8.0.1
b66b0000 b67d4000 r-xp /lib/libc-2.20-2014.11.so
b67e9000 b6802000 r-xp /lib/libgcc_s-4.9.so.1
b6812000 b68f4000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6905000 b692f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6940000 b697c000 r-xp /usr/lib/libsystemd.so.0.4.0
b697e000 b6a01000 r-xp /usr/lib/libedje.so.1.13.0
b6a14000 b6a32000 r-xp /usr/lib/libecore.so.1.13.0
b6a52000 b6bd9000 r-xp /usr/lib/libevas.so.1.13.0
b6c0e000 b6c22000 r-xp /lib/libpthread-2.20-2014.11.so
b6c36000 b6e6a000 r-xp /usr/lib/libelementary.so.1.13.0
b6e99000 b6e9d000 r-xp /usr/lib/libsmack.so.1.0.0
b6ead000 b6eb4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec4000 b6ec6000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed6000 b6ed9000 r-xp /usr/lib/libbundle.so.0.1.22
b6ee9000 b6eeb000 r-xp /lib/libdl-2.20-2014.11.so
b6efc000 b6f14000 r-xp /usr/lib/libaul.so.0.1.0
b6f28000 b6f2d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f3e000 b6f4b000 r-xp /usr/lib/liblptcp.so
b6f5d000 b6f61000 r-xp /usr/lib/libsys-assert.so
b6f72000 b6f92000 r-xp /lib/ld-2.20-2014.11.so
b6fa3000 b6fa8000 r-xp /usr/bin/launchpad-loader
b7936000 b7e4b000 rw-p [heap]
beab3000 bead4000 rw-p [stack]
b7936000 b7e4b000 rw-p [heap]
beab3000 bead4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9346)
Call Stack Count: 19
 0: _ZN6Scroll18callback_anim_stopEPvP10_Eo_OpaqueS0_ + 0x15 (0xb2811406) [/opt/usr/apps/org.example.client/bin/client] + 0x1a406
 1: (0xb6ab87ed) [/usr/lib/libevas.so.1] + 0x667ed
 2: (0xb5f00219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5efefb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: evas_object_smart_callback_call + 0x38 (0xb6ab9edd) [/usr/lib/libevas.so.1] + 0x67edd
 5: (0xb6d5faef) [/usr/lib/libelementary.so.1] + 0x129aef
 6: (0xb6a1deeb) [/usr/lib/libecore.so.1] + 0x9eeb
 7: ecore_animator_custom_tick + 0x26 (0xb6a1eb7f) [/usr/lib/libecore.so.1] + 0xab7f
 8: (0xb62b115f) [/usr/lib/libecore_x.so.1] + 0x3215f
 9: (0xb6a22e93) [/usr/lib/libecore.so.1] + 0xee93
10: (0xb6a258af) [/usr/lib/libecore.so.1] + 0x118af
11: ecore_main_loop_begin + 0x3e (0xb6a25c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f2b2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3fe1909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: _ZN6Window10makeWindowEiPPc + 0x11e (0xb2810373) [/opt/usr/apps/org.example.client/bin/client] + 0x19373
15: main + 0x40 (0xb27fba41) [/opt/usr/apps/org.example.client/bin/client] + 0x4a41
16: (0xb6fa4bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
17: __libc_start_main + 0x114 (0xb66c64bc) [/lib/libc.so.6] + 0x164bc
18: (0xb6fa4eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
  Name[client] enable[1] system[0]
04-14 03:25:28.050+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-14 03:25:28.060+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-14 03:25:28.060+0900 I/Tizen::App( 1305): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-14 03:25:28.060+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-14 03:25:28.070+0900 I/Tizen::App( 1305): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (416) > appName = [client]
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-14 03:25:28.080+0900 E/PKGMGR_INFO( 1305): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (683) > Application count(1) in this package
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (840) > Enter.
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (703) > Exit.
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-14 03:25:28.090+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-14 03:25:28.090+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9244]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (416) > appName = [client]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (131) > Enter
04-14 03:25:28.110+0900 I/Tizen::App( 1305): (137) > org.example.client does not have launch condition
04-14 03:25:28.110+0900 I/Tizen::App( 1305): (883) > Exit.
04-14 03:25:28.120+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-14 03:25:29.552+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:25:29.552+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:25:32.244+0900 W/AUL     ( 9298): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-14 03:25:32.244+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 0
04-14 03:25:32.254+0900 I/AUL     (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-14 03:25:32.264+0900 I/AUL     (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-14 03:25:32.264+0900 E/AUL_AMD (  616): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-14 03:25:32.264+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 9298
04-14 03:25:32.264+0900 E/AUL_AMD (  616): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-14 03:25:32.264+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:25:32.264+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:25:32.274+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:25:32.274+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:25:32.274+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:25:32.284+0900 I/abc     ( 9035): abc
04-14 03:25:32.284+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:25:32.284+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:25:32.314+0900 E/TBM     ( 9035): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:25:32.375+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9035, appid: org.example.client
04-14 03:25:32.375+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:25:32.385+0900 W/AUL     ( 9298): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9035)
04-14 03:25:32.595+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(514) > [APP 9035] Event: RESET State: CREATED
04-14 03:25:32.595+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:25:32.605+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.605+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.615+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.615+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.615+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.615+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.625+0900 W/APP_CORE( 9035): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
04-14 03:25:32.625+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:25:32.635+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:32.635+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:32.645+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:25:32.645+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:32.655+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:32.665+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:32.745+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:25:32.745+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:32.745+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(514) > [APP 9035] Event: RESUME State: CREATED
04-14 03:25:32.745+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:25:32.745+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:25:32.745+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9035) status(3)
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:32.745+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9035)
04-14 03:25:32.745+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9035, appid: org.example.client, status: fg
04-14 03:25:32.755+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:25:32.755+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(625) > [APP 9035] Initial Launching, call the resume_cb
04-14 03:25:32.755+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:32.765+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:25:32.765+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:25:32.765+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:25:33.105+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9035) status(0)
04-14 03:25:33.436+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:25:33.436+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9035.
04-14 03:25:33.446+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.678
04-14 03:25:33.956+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28861401
04-14 03:25:34.046+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28861489
04-14 03:25:34.206+0900 I/UXT     ( 9311): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:25:34.346+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28861797
04-14 03:25:34.356+0900 I/MY_LOG  ( 9035): Button pressed
04-14 03:25:34.437+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28861885
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9035) : db/ise/keysound error
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:25:34.497+0900 I/MY_LOG  ( 9035): Button unpressed
04-14 03:25:35.157+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28862598
04-14 03:25:35.157+0900 I/MY_LOG  ( 9035): Button pressed
04-14 03:25:35.257+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28862697
04-14 03:25:35.267+0900 I/MY_LOG  ( 9035): Button unpressed
04-14 03:25:35.297+0900 D/basicui ( 9035): successed to load edc file
04-14 03:25:36.789+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28864235
04-14 03:25:36.879+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28864323
04-14 03:25:36.909+0900 D/basicui ( 9035): successed to load edc file
04-14 03:25:36.939+0900 I/MY_LOG  ( 9035): change
04-14 03:25:37.009+0900 I/MY_LOG  ( 9035): change
04-14 03:25:37.750+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:25:38.440+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28865888
04-14 03:25:39.381+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28866826
04-14 03:25:39.722+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28867164
04-14 03:25:40.162+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28867605
04-14 03:25:40.402+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28867848
04-14 03:25:40.543+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9035 pgid = 9035
04-14 03:25:40.543+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(9035)
04-14 03:25:40.553+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:40.563+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:25:40.563+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:25:40.593+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:25:40.593+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:25:40.593+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:25:40.593+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 9035
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[9035] terminate event is forwarded
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 9035, ]
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (512) > Not registered pid(9035)
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:25:40.593+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:40.593+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9035
04-14 03:25:40.593+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9035
04-14 03:25:40.603+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.682
04-14 03:25:40.613+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:25:40.623+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:40.623+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9035.
04-14 03:25:40.643+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:25:40.643+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:40.643+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:25:40.643+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:40.653+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:25:40.673+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:25:40.673+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:40.693+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:25:40.693+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109035636c691492107940
04-14 03:25:40.713+0900 E/weather-common( 1405): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-14 03:25:40.723+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:40.733+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-14 03:25:40.733+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:40.743+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:25:40.743+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:40.743+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb86d2890]
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb86d2890
04-14 03:25:40.793+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:25:40.793+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:25:40.793+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:25:40.793+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:25:40.793+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:25:40.923+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28868376
04-14 03:25:41.243+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28868697
04-14 03:25:41.503+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-14 03:25:41.794+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28869241
04-14 03:25:42.244+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28869694
04-14 03:25:42.504+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-14 03:25:42.745+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28870198
04-14 03:25:42.845+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28870297
04-14 03:25:42.855+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-14 03:25:42.855+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 1
04-14 03:25:42.855+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 860
04-14 03:25:42.865+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:25:42.865+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:25:42.865+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:25:42.865+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:25:42.865+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:25:42.885+0900 I/abc     ( 9311): abc
04-14 03:25:42.885+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:25:42.885+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:25:42.915+0900 E/TBM     ( 9311): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:25:42.965+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9311, appid: org.example.client
04-14 03:25:42.965+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:25:42.965+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9311)
04-14 03:25:43.185+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(514) > [APP 9311] Event: RESET State: CREATED
04-14 03:25:43.185+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:25:43.195+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.195+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.205+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.205+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.205+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.205+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.215+0900 W/APP_CORE( 9311): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
04-14 03:25:43.215+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:25:43.215+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:43.215+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:43.235+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:25:43.235+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:43.245+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:43.255+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:43.325+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(514) > [APP 9311] Event: RESUME State: CREATED
04-14 03:25:43.325+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:25:43.325+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:43.325+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:25:43.325+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:25:43.325+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:25:43.325+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:25:43.335+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9311) status(3)
04-14 03:25:43.335+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9311)
04-14 03:25:43.335+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9311, appid: org.example.client, status: fg
04-14 03:25:43.335+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:25:43.335+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(625) > [APP 9311] Initial Launching, call the resume_cb
04-14 03:25:43.335+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:43.345+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:25:43.345+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:25:43.345+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:25:43.686+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9311) status(0)
04-14 03:25:44.006+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.685
04-14 03:25:44.016+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:25:44.016+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9311.
04-14 03:25:44.146+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28871596
04-14 03:25:44.246+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28871695
04-14 03:25:44.556+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28872003
04-14 03:25:44.556+0900 I/MY_LOG  ( 9311): Button pressed
04-14 03:25:44.637+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28872080
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9311) : db/ise/keysound error
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:25:44.697+0900 I/MY_LOG  ( 9311): Button unpressed
04-14 03:25:45.017+0900 I/UXT     ( 9346): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:25:45.497+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28872945
04-14 03:25:45.497+0900 I/MY_LOG  ( 9311): Button pressed
04-14 03:25:45.587+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28873033
04-14 03:25:45.587+0900 I/MY_LOG  ( 9311): Button unpressed
04-14 03:25:45.617+0900 D/basicui ( 9311): successed to load edc file
04-14 03:25:47.009+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28874453
04-14 03:25:47.099+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28874541
04-14 03:25:47.119+0900 D/basicui ( 9311): successed to load edc file
04-14 03:25:47.139+0900 I/MY_LOG  ( 9311): change
04-14 03:25:47.209+0900 I/MY_LOG  ( 9311): change
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.900+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28875345
04-14 03:25:48.340+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:25:48.741+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28876185
04-14 03:25:49.391+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28876835
04-14 03:25:49.491+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109311636c691492107949
04-14 03:25:49.521+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9311 pgid = 9311
04-14 03:25:49.521+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(9311)
04-14 03:25:49.521+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:49.551+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:25:49.551+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:49.551+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:49.551+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:25:49.551+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:25:49.581+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:25:49.581+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:25:49.581+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:25:49.591+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[9311] terminate event is forwarded
04-14 03:25:49.591+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:25:49.591+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 9311, ]
04-14 03:25:49.591+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:25:49.591+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:25:49.591+0900 I/Tizen::App( 1305): (512) > Not registered pid(9311)
04-14 03:25:49.591+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:25:49.591+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:49.591+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 9311
04-14 03:25:49.591+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9311
04-14 03:25:49.591+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9311
04-14 03:25:49.601+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.689
04-14 03:25:49.611+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:25:49.611+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:25:49.611+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:49.611+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:25:49.611+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:49.611+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9311.
04-14 03:25:49.611+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:49.631+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:25:49.651+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:25:49.661+0900 E/weather-common( 1405): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-14 03:25:49.671+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:25:49.671+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:49.681+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-14 03:25:49.681+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:49.681+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:25:49.681+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:49.691+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:49.721+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb867bef0]
04-14 03:25:49.721+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:25:49.721+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb867bef0
04-14 03:25:49.721+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:25:49.731+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:25:49.731+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:25:49.731+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:25:49.731+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:25:49.731+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:54.386+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28881831
04-14 03:25:54.516+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28881963
04-14 03:25:54.516+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-14 03:25:54.516+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 1
04-14 03:25:54.526+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 860
04-14 03:25:54.536+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:25:54.536+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:25:54.536+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:25:54.536+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:25:54.536+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:25:54.556+0900 I/abc     ( 9346): abc
04-14 03:25:54.556+0900 I/CAPI_APPFW_APPLICATION( 9346): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:25:54.556+0900 I/CAPI_APPFW_APPLICATION( 9346): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:25:54.586+0900 E/TBM     ( 9346): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:25:54.636+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9346, appid: org.example.client
04-14 03:25:54.636+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:25:54.636+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9346)
04-14 03:25:54.866+0900 I/APP_CORE( 9346): appcore-efl.c: __do_app(514) > [APP 9346] Event: RESET State: CREATED
04-14 03:25:54.866+0900 I/CAPI_APPFW_APPLICATION( 9346): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:25:54.876+0900 E/EFL     ( 9346): edje<9346> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:54.876+0900 E/EFL     ( 9346): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:54.887+0900 E/EFL     ( 9346): edje<9346> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:54.887+0900 E/EFL     ( 9346): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:54.887+0900 E/EFL     ( 9346): edje<9346> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:54.887+0900 E/EFL     ( 9346): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:54.897+0900 W/APP_CORE( 9346): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
04-14 03:25:54.897+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:25:54.907+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:54.907+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:54.917+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:25:54.927+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:54.927+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:54.947+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:55.017+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:25:55.017+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:55.017+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:25:55.017+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:25:55.017+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:25:55.017+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:25:55.027+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9346) status(3)
04-14 03:25:55.027+0900 I/APP_CORE( 9346): appcore-efl.c: __do_app(514) > [APP 9346] Event: RESUME State: CREATED
04-14 03:25:55.027+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9346)
04-14 03:25:55.027+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9346, appid: org.example.client, status: fg
04-14 03:25:55.037+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:25:55.037+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:25:55.037+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:25:55.047+0900 I/APP_CORE( 9346): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:25:55.047+0900 I/APP_CORE( 9346): appcore-efl.c: __do_app(625) > [APP 9346] Initial Launching, call the resume_cb
04-14 03:25:55.047+0900 I/CAPI_APPFW_APPLICATION( 9346): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:55.387+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9346) status(0)
04-14 03:25:55.667+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.691
04-14 03:25:55.677+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:25:55.677+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9346.
04-14 03:25:55.757+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28883202
04-14 03:25:55.867+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28883312
04-14 03:25:56.358+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28883800
04-14 03:25:56.358+0900 I/MY_LOG  ( 9346): Button pressed
04-14 03:25:56.468+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28883910
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9346) : db/ise/keysound error
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:25:56.498+0900 I/UXT     ( 9414): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:25:56.528+0900 I/MY_LOG  ( 9346): Button unpressed
04-14 03:25:57.289+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28884729
04-14 03:25:57.289+0900 I/MY_LOG  ( 9346): Button pressed
04-14 03:25:57.399+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28884839
04-14 03:25:57.399+0900 I/MY_LOG  ( 9346): Button unpressed
04-14 03:25:57.439+0900 D/basicui ( 9346): successed to load edc file
04-14 03:25:58.740+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28886183
04-14 03:25:58.830+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28886271
04-14 03:25:58.860+0900 D/basicui ( 9346): successed to load edc file
04-14 03:25:58.880+0900 I/MY_LOG  ( 9346): change
04-14 03:25:58.960+0900 I/MY_LOG  ( 9346): change
04-14 03:26:00.022+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:26:00.272+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(195) > ""
04-14 03:26:00.272+0900 E/UXT     (  645): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:26
04-14 03:26:00.272+0900 I/INDICATOR(  645): clock.c: getTimeFormatted(176) > "time format : 오전 3:26"
04-14 03:26:00.272+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:26"
04-14 03:26:00.272+0900 W/INDICATOR(  645): clock.c: indicator_clock_changed_cb(272) > 
04-14 03:26:00.272+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145724326 Time: <font_size=31> </font_size> <font_size=31> 오전 3:26</font_size></font>"
04-14 03:26:03.185+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28890632
04-14 03:26:05.367+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28892809
04-14 03:26:05.587+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109346636c69149210796
