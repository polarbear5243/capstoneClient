S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 16577
Date: 2017-06-13 14:03:12+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb280464e

Register Information
r0   = 0xb7fe7eb8, r1   = 0xb7fe3df0
r2   = 0xb7fe3df0, r3   = 0xb7fe7eb8
r4   = 0xb3ff3a3c, r5   = 0xbebe8484
r6   = 0x00000001, r7   = 0xbebe8348
r8   = 0xbebe8478, r9   = 0xb7f89830
r10  = 0xbebe8498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbebe82ec
lr   = 0xb28045d5, pc   = 0xb280464e
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     68056 KB
Buffers:     62612 KB
Cached:     228972 KB
VmPeak:      98668 KB
VmSize:      98664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19560 KB
VmRSS:       19560 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          74 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16577 TID = 16577
16577 16587 16606 16611 

Maps Information
b13b5000 b13bd000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13cf000 b1bce000 rw-p [stack:16611]
b1bce000 b1bcf000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bdf000 b1bf3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c07000 b1c08000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c18000 b1c1b000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c2c000 b1c2d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c3d000 b1c3f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c4f000 b1c51000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c61000 b1c71000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c81000 b1c8d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c9f000 b249e000 rw-p [stack:16606]
b27cf000 b27d6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27e9000 b27ef000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27ff000 b282f000 r-xp /opt/usr/apps/org.example.client/bin/client
b2978000 b2a5b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a92000 b2aba000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2acc000 b32cb000 rw-p [stack:16587]
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
b7dcf000 b8014000 rw-p [heap]
bebc8000 bebe9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16577)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb280464e) [/opt/usr/apps/org.example.client/bin/client] + 0x564e
 1: _ZN7MyLoginC2EP9Naviframe + 0x84 (0xb28045d5) [/opt/usr/apps/org.example.client/bin/client] + 0x55d5
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb28043a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb281d5cf) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5cf
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb281d745) [/opt/usr/apps/org.example.client/bin/client] + 0x1e745
 5: (0xb3fe14f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6f2b203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3fe1909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb281dacf) [/opt/usr/apps/org.example.client/bin/client] + 0x1eacf
 9: main + 0x40 (0xb2804129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6fa4bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb66c64bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6fa4eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
e_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17177025
06-13 14:03:10.933+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17177082
06-13 14:03:10.933+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:03:10.933+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:03:10.933+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:03:10.933+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:10.963+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:10.973+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:10.973+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:03:10.973+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:03:10.973+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:03:10.973+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:03:10.983+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:03:10.983+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:03:10.983+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:03:10.983+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:03:11.093+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:11.103+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:11.113+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:03:11.113+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:03:11.123+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:11.163+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16205 pgid = 16205
06-13 14:03:11.163+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16205)
06-13 14:03:11.183+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:11.193+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:11.193+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:03:11.193+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:03:11.193+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:03:11.193+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:03:11.203+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:03:11.203+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:03:11.203+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:03:11.213+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[16205] terminate event is forwarded
06-13 14:03:11.213+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:03:11.213+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 16205, ]
06-13 14:03:11.213+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:03:11.213+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:03:11.213+0900 I/Tizen::App( 1175): (512) > Not registered pid(16205)
06-13 14:03:11.213+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:03:11.213+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:03:11.213+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16205
06-13 14:03:11.213+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16205
06-13 14:03:11.213+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16205
06-13 14:03:11.233+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:03:11.233+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 16205.
06-13 14:03:11.283+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:11.293+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:11.584+0900 I/UXT     (16589): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:03:11.644+0900 E/TBM     (16589): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:11.644+0900 I/MALI    (16589): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=16589   open drm_fd=29 
06-13 14:03:11.724+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17177933
06-13 14:03:11.744+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:03:11.744+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:03:11.764+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:03:11.764+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:03:11.764+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:03:11.764+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:03:11.794+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17177999
06-13 14:03:11.804+0900 E/EFL     (16589): edje<16589> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:11.804+0900 E/EFL     (16589): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:11.814+0900 E/EFL     (16589): edje<16589> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:11.814+0900 E/EFL     (16589): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:11.814+0900 E/EFL     (16589): edje<16589> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:11.814+0900 E/EFL     (16589): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:12.204+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17178415
06-13 14:03:12.304+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17178514
06-13 14:03:12.565+0900 W/cluster-view( 1167): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
06-13 14:03:12.705+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17178915
06-13 14:03:12.775+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17178982
06-13 14:03:12.775+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:03:12.775+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:03:12.775+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:03:12.785+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:03:12.785+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:12.795+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:03:12.795+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:03:12.795+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:03:12.805+0900 I/abc     (16577): abc
06-13 14:03:12.805+0900 I/CAPI_APPFW_APPLICATION(16577): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:03:12.805+0900 I/CAPI_APPFW_APPLICATION(16577): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:03:12.835+0900 E/TBM     (16577): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:12.895+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16577, appid: org.example.client
06-13 14:03:12.895+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:12.905+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(16577)
06-13 14:03:13.916+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16577 pgid = 16577
06-13 14:03:13.916+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16577)
06-13 14:03:13.926+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 16577.
06-13 14:03:13.926+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1662
06-13 14:03:13.956+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:03:13.956+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:03:13.956+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:03:13.956+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16577.
06-13 14:03:13.956+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16577
06-13 14:03:13.956+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16577
06-13 14:03:13.956+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16577
06-13 14:03:13.966+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1663
06-13 14:03:14.737+0900 I/UXT     (16621): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:03:14.827+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17181034
06-13 14:03:14.827+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17181034
06-13 14:03:14.827+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:03:14.827+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:03:14.827+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:03:15.127+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:03:15.127+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:03:15.127+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:03:15.127+0900 E/STARTER (  721): )
06-13 14:03:15.137+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:03:15.137+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:03:15.137+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:03:15.137+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:03:15.147+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:03:15.147+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:03:15.147+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:03:15.147+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:03:15.147+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:03:15.157+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:15.167+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:03:15.167+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:03:15.167+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:03:15.177+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 I/CAPI_APPFW_APPLICATION(16589): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:03:15.187+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 14:03:15.187+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 14:03:15.187+0900 I/CAPI_APPFW_APPLICATION(16589): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:03:15.267+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16589, appid: com.samsung.task-mgr
06-13 14:03:15.267+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:15.267+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16589)
06-13 14:03:15.267+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:03:15.287+0900 W/TASK_MGR_LITE(16589): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:03:15.297+0900 I/GXT_SIB (16589): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:03:15.347+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:15.347+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:15.357+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.367+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:03:15.367+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:03:15.367+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.377+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:15.377+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.387+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.397+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:03:15.397+0900 E/RUA     (16589): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:03:15.397+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:03:15.407+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.407+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:03:15.427+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.437+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.457+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.467+0900 W/CRASH_MANAGER(16473): worker.c: worker_job(1199) > 0416525636c691497330188
06-13 14:03:15.477+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.477+0900 I/APP_CORE(16589): appcore-efl.c: __do_app(514) > [APP 16589] Event: RESET State: CREATED
06-13 14:03:15.477+0900 I/CAPI_APPFW_APPLICATION(16589): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:03:15.487+0900 E/EFL     (16589): edje<16589> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:15.487+0900 E/EFL     (16589): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:15.487+0900 E/EFL     (16589): edje<16589> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:15.487+0900 E/EFL     (16589): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:15.487+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.497+0900 W/APP_CORE(16589): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200003
06-13 14:03:15.497+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:03:15.507+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.527+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.628+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(16589) status(0)
06-13 14:03:15.628+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(16589) status(0)
06-13 14:03:15.628+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:03:15.628+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:03:15.628+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:03:15.638+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17181826
06-13 14:03:15.638+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:03:15.638+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:03:15.638+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:03:15.638+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:03:15.638+0900 I/APP_CORE(16589): appcore-efl.c: __do_app(514) > [APP 16589] Event: RESUME State: CREATED
06-13 14:03:15.638+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(16589) status(3)
06-13 14:03:15.638+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:03:15.638+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:03:15.638+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:03:15.638+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(16589)
06-13 14:03:15.638+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:03:15.638+0900 E/STARTER (  721): )
06-13 14:03:15.638+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 16589, appid: com.samsung.task-mgr, status: fg
06-13 14:03:15.648+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17181826
06-13 14:03:15.648+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:03:15.648+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:03:15.648+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.658+0900 I/APP_CORE(16589): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:03:15.658+0900 I/APP_CORE(16589): appcore-efl.c: __do_app(625) > [APP 16589] Initial Launching, call the resume_cb
06-13 14:03:15.658+0900 I/CAPI_APPFW_APPLICATION(16589): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:03:15.658+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:03:15.658+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:03:15.658+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:03:15.768+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:03:15.928+0900 E/EFL     (16589): ecore_x<16589> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17182142
06-13 14:03:15.928+0900 E/TASK_MGR_LITE(16589): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 14:03:16.008+0900 E/EFL     (16589): ecore_x<16589> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17182220
06-13 14:03:16.328+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1667
06-13 14:03:16.338+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:03:16.338+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 16589.
06-13 14:03:16.508+0900 E/TASK_MGR_LITE(16589): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 14:03:16.508+0900 E/EFL     (16589): ecore_x<16589> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17182727
06-13 14:03:16.589+0900 E/EFL     (16589): ecore_x<16589> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17182804
06-13 14:03:17.009+0900 E/EFL     (16589): ecore_x<16589> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17183220
06-13 14:03:17.109+0900 E/EFL     (16589): ecore_x<16589> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17183320
06-13 14:03:17.179+0900 I/UXT     (16655): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:03:17.229+0900 E/TBM     (16655): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:17.229+0900 I/MALI    (16655): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=16655   open drm_fd=30 
06-13 14:03:17.359+0900 E/EFL     (16655): edje<16655> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:17.359+0900 E/EFL     (16655): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:17.359+0900 E/EFL     (16655): edje<16655> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:17.359+0900 E/EFL     (16655): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:17.359+0900 E/EFL     (16655): edje<16655> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:17.359+0900 E/EFL     (16655): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:17.409+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:03:17.409+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:03:17.409+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(16589)
06-13 14:03:17.409+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 16589, appid: com.samsung.task-mgr, status: bg
06-13 14:03:17.409+0900 I/CAPI_APPFW_APPLICATION(16589): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:03:17.409+0900 W/TASK_MGR_LITE(16589): task-mgr-lite.c: _pause_app(406) > 
06-13 14:03:17.409+0900 I/CAPI_APPFW_APPLICATION(16589): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:03:17.409+0900 E/TASK_MGR_LITE(16589): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:03:17.409+0900 E/EFL     (16589): eo<16589> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x8004763d's acvie is  NULL, entry: 0xb32ed1f8, 0xb772c030, 0
06-13 14:03:17.409+0900 E/EFL     (16589): eo<16589> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x8004763d is not pointing to a valid object. Maybe it has already been freed.
06-13 14:03:17.409+0900 E/EFL     (16589): eo<16589> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x8004763d) is an invalid ref.
06-13 14:03:17.429+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:03:17.429+0900 E/APP_CORE(16589): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:03:17.439+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:17.439+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:03:17.439+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:03:17.439+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:03:17.439+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:03:17.439+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:03:17.459+0900 I/MALI    (16589): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=16589   close drm_fd=29 
06-13 14:03:17.469+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:03:17.469+0900 E/EFL     (  665): <665> lib/ecore_ipc/ecore_ipc.c:803 ecore_ipc_client_send() safety check failed: !cl->client is true
06-13 14:03:17.509+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:17.509+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:03:17.509+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:03:17.509+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:03:17.529+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:03:17.529+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:03:17.559+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:03:17.559+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:17.579+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:17.579+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:17.579+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:17.579+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:17.579+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:17.579+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:17.589+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:17.589+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:03:17.589+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:03:17.589+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:03:17.589+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:03:17.690+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:17.700+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:17.780+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16589 pgid = 16589
06-13 14:03:17.780+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16589)
06-13 14:03:17.820+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:03:17.820+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:03:17.820+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:03:17.820+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16589
06-13 14:03:17.820+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[16589] terminate event is forwarded
06-13 14:03:17.830+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:03:17.830+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 16589, ]
06-13 14:03:17.830+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:03:17.830+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:03:17.830+0900 I/Tizen::App( 1175): (512) > Not registered pid(16589)
06-13 14:03:17.830+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:03:17.830+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:03:17.830+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16589
06-13 14:03:17.830+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16589
06-13 14:03:17.830+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1670
06-13 14:03:17.840+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:03:17.840+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 16589.
06-13 14:03:17.990+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17184149
06-13 14:03:17.990+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:03:17.990+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17184202
06-13 14:03:17.990+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:03:17.990+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:03:17.990+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:03:18.010+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:03:18.010+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:03:18.010+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:03:18.010+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:03:18.150+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17184308
06-13 14:03:18.150+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:03:18.150+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17184365
06-13 14:03:18.150+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:03:18.150+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:03:18.150+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:03:18.160+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:03:18.160+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:03:18.170+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:03:18.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:18.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:18.180+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:18.180+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:18.180+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:18.180+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:18.180+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:18.180+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:03:18.180+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:03:18.180+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:03:18.180+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:03:18.190+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:03:18.190+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:03:18.190+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:03:18.190+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:03:18.250+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:18.250+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:18.330+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:03:18.330+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:03:18.330+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnFocusedViewChanged(4344) >  view type is not chaged,same view[0]
06-13 14:03:18.340+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:03:18.350+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:18.350+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:18.350+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:18.350+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:18.350+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:18.360+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:18.360+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:18.360+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:03:18.360+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:03:18.360+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:03:18.360+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:03:18.430+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:18.430+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:22.234+0900 W/CRASH_MANAGER(16473): worker.c: worker_job(1199) > 0416577636c69149733019
