S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2584
Date: 2017-04-08 23:36:46+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2584, uid 5000)

Register Information
r0   = 0xb823a958, r1   = 0xb823a958
r2   = 0x00000000, r3   = 0xb81ebf28
r4   = 0xb27b8b81, r5   = 0xb81d8228
r6   = 0xb823e3d0, r7   = 0xbe9d3180
r8   = 0x800d0084, r9   = 0xb5eb8708
r10  = 0xb823b480, fp   = 0x00000000
ip   = 0x800d0084, sp   = 0xbe9d3170
lr   = 0xb27b8ba5, pc   = 0xb27af434
cpsr = 0x600f0030

Memory Information
MemTotal:   987012 KB
MemFree:    133704 KB
Buffers:     37796 KB
Cached:     331164 KB
VmPeak:     135416 KB
VmSize:     134240 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29392 KB
VmRSS:       28572 KB
VmData:      46168 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35792 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2584 TID = 2584
2584 2585 2974 2980 3020 

Maps Information
af12e000 af92d000 rw-p [stack:3020]
b0f32000 b0f43000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f53000 b0f58000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b135a000 b1362000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1374000 b1b73000 rw-p [stack:2980]
b1b73000 b1b74000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b84000 b1b98000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bac000 b1bad000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bbd000 b1bc0000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bd1000 b1bd2000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1be2000 b1be4000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bf4000 b1bf6000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c06000 b1c16000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c26000 b1c32000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c44000 b2443000 rw-p [stack:2974]
b2774000 b277b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b278e000 b2794000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27a4000 b27c3000 r-xp /opt/usr/apps/org.example.client/bin/client
b291c000 b29ff000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a36000 b2a5e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a70000 b326f000 rw-p [stack:2585]
b326f000 b3271000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3281000 b328b000 r-xp /lib/libnss_files-2.20-2014.11.so
b329c000 b32a5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32b6000 b32c7000 r-xp /lib/libnsl-2.20-2014.11.so
b32da000 b32e0000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32f1000 b32f2000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b331a000 b3321000 r-xp /usr/lib/libminizip.so.1.0.0
b3331000 b3336000 r-xp /usr/lib/libstorage.so.0.1
b3346000 b33a5000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33bb000 b33cf000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33df000 b3423000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3433000 b343b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b344b000 b347b000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b348e000 b3547000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b355b000 b35ae000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35bf000 b35da000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ea000 b36ab000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36be000 b36ce000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36de000 b36eb000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36fc000 b3703000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3713000 b3754000 r-xp /usr/lib/libmdm.so.1.2.12
b3764000 b376c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b377b000 b378b000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ac000 b380c000 r-xp /usr/lib/libasound.so.2.0.0
b381e000 b3821000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3831000 b3834000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3844000 b3849000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3859000 b385a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b386a000 b3875000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3889000 b3890000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a0000 b38a6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38b6000 b38bb000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38cb000 b38e6000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38f6000 b38fd000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b390d000 b3910000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3921000 b394f000 r-xp /usr/lib/libidn.so.11.5.44
b395f000 b3975000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3986000 b3990000 r-xp /usr/lib/libcares.so.2.1.0
b39a0000 b39aa000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39ba000 b39bc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39cc000 b39cd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39dd000 b39e1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39f2000 b3a1a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a2b000 b3a54000 r-xp /usr/lib/libturbojpeg.so
b3a74000 b3a7a000 r-xp /usr/lib/libgif.so.4.1.6
b3a8a000 b3ad0000 r-xp /usr/lib/libcurl.so.4.3.0
b3ae1000 b3b02000 r-xp /usr/lib/libexif.so.12.3.3
b3b1d000 b3b32000 r-xp /usr/lib/libtts.so
b3b43000 b3b4b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b5b000 b3c21000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c41000 b3d39000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d58000 b3e26000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e3d000 b3e3f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e4f000 b3e55000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e65000 b3e88000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e99000 b3e9b000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eab000 b3ead000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ebe000 b3ec3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eda000 b3edc000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eec000 b3ef3000 r-xp /usr/lib/libsensord-share.so
b3f03000 b3f1b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f2c000 b3f2f000 r-xp /usr/lib/libXv.so.1.0.0
b3f3f000 b3f44000 r-xp /usr/lib/libutilX.so.1.1.0
b3f54000 b3f59000 r-xp /usr/lib/libappcore-common.so.1.1
b3f69000 b3f70000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f83000 b3f87000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f98000 b4076000 r-xp /usr/lib/libCOREGL.so.4.0
b4096000 b4099000 r-xp /usr/lib/libuuid.so.1.3.0
b40a9000 b40c0000 r-xp /usr/lib/libblkid.so.1.1.0
b40d1000 b40d3000 r-xp /usr/lib/libXau.so.6.0.0
b40e3000 b412a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b413c000 b4142000 r-xp /usr/lib/libjson-c.so.2.0.1
b4153000 b4157000 r-xp /usr/lib/libogg.so.0.7.1
b4167000 b4189000 r-xp /usr/lib/libvorbis.so.0.4.3
b4199000 b427d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4299000 b429c000 r-xp /usr/lib/libEGL.so.1.4
b42ad000 b42b3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42c3000 b42c5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42d5000 b42e2000 r-xp /usr/lib/libGLESv2.so.2.0
b42f3000 b4355000 r-xp /usr/lib/libpixman-1.so.0.28.2
b436a000 b4382000 r-xp /usr/lib/libmount.so.1.1.0
b4394000 b43a8000 r-xp /usr/lib/libxcb.so.1.1.0
b43b8000 b43bf000 r-xp /lib/libcrypt-2.20-2014.11.so
b43f7000 b43f9000 r-xp /usr/lib/libiri.so
b4409000 b4414000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4425000 b445b000 r-xp /usr/lib/libpulse.so.0.16.2
b446c000 b44af000 r-xp /usr/lib/libsndfile.so.1.0.25
b44c4000 b44d9000 r-xp /lib/libexpat.so.1.5.2
b44eb000 b45a9000 r-xp /usr/lib/libcairo.so.2.11200.14
b45bd000 b45c5000 r-xp /usr/lib/libdrm.so.2.4.0
b45d5000 b45d8000 r-xp /usr/lib/libdri2.so.0.0.0
b45e8000 b4636000 r-xp /usr/lib/libssl.so.1.0.0
b464b000 b4657000 r-xp /usr/lib/libeeze.so.1.13.0
b4668000 b4671000 r-xp /usr/lib/libethumb.so.1.13.0
b4681000 b4684000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4694000 b484b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5636000 b563f000 r-xp /usr/lib/libXi.so.6.1.0
b564f000 b5651000 r-xp /usr/lib/libXgesture.so.7.0.0
b5661000 b5665000 r-xp /usr/lib/libXtst.so.6.1.0
b5675000 b567b000 r-xp /usr/lib/libXrender.so.1.3.0
b568b000 b5691000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a1000 b56a3000 r-xp /usr/lib/libXinerama.so.1.0.0
b56b4000 b56b7000 r-xp /usr/lib/libXfixes.so.3.1.0
b56c7000 b56d2000 r-xp /usr/lib/libXext.so.6.4.0
b56e2000 b56e4000 r-xp /usr/lib/libXdamage.so.1.1.0
b56f4000 b56f6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5706000 b57e8000 r-xp /usr/lib/libX11.so.6.3.0
b57fc000 b5803000 r-xp /usr/lib/libXcursor.so.1.0.2
b5813000 b582b000 r-xp /usr/lib/libudev.so.1.6.0
b582d000 b5830000 r-xp /lib/libattr.so.1.1.0
b5840000 b5860000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5861000 b5866000 r-xp /usr/lib/libffi.so.6.0.2
b5877000 b588f000 r-xp /lib/libz.so.1.2.8
b589f000 b58a1000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b1000 b5986000 r-xp /usr/lib/libxml2.so.2.9.2
b599b000 b5a36000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a52000 b5a55000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a65000 b5a7e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a8f000 b5aa0000 r-xp /lib/libresolv-2.20-2014.11.so
b5ab4000 b5b2e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b43000 b5b45000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b55000 b5b5c000 r-xp /usr/lib/libembryo.so.1.13.0
b5b6c000 b5b76000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b87000 b5b9f000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb0000 b5bd3000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bf4000 b5c08000 r-xp /usr/lib/libector.so.1.13.0
b5c19000 b5c31000 r-xp /usr/lib/liblua-5.1.so
b5c42000 b5c99000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cad000 b5cd5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ce6000 b5cf9000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d0a000 b5d44000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d55000 b5d63000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d73000 b5d7b000 r-xp /usr/lib/libtbm.so.1.0.0
b5d8b000 b5d98000 r-xp /usr/lib/libeio.so.1.13.0
b5da8000 b5daa000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dba000 b5dbf000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dcf000 b5de6000 r-xp /usr/lib/libefreet.so.1.13.0
b5df8000 b5e18000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e28000 b5e48000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e4a000 b5e50000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e60000 b5e71000 r-xp /usr/lib/libemotion.so.1.13.0
b5e82000 b5e89000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e99000 b5ea8000 r-xp /usr/lib/libeo.so.1.13.0
b5eb9000 b5ecb000 r-xp /usr/lib/libecore_input.so.1.13.0
b5edc000 b5ee1000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef1000 b5f0a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f1a000 b5f37000 r-xp /usr/lib/libeet.so.1.13.0
b5f50000 b5f98000 r-xp /usr/lib/libeina.so.1.13.0
b5fa9000 b5fb9000 r-xp /usr/lib/libefl.so.1.13.0
b5fca000 b60af000 r-xp /usr/lib/libicuuc.so.51.1
b60cc000 b620c000 r-xp /usr/lib/libicui18n.so.51.1
b6223000 b625b000 r-xp /usr/lib/libecore_x.so.1.13.0
b626d000 b6270000 r-xp /lib/libcap.so.2.21
b6280000 b62a9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62ba000 b62c1000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62d3000 b630a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b631b000 b6406000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6419000 b6492000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64a4000 b64a9000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64b9000 b64c3000 r-xp /usr/lib/libvconf.so.0.2.45
b64d3000 b64d5000 r-xp /usr/lib/libvasum.so.0.3.1
b64e5000 b64e7000 r-xp /usr/lib/libttrace.so.1.1
b64f7000 b64fa000 r-xp /usr/lib/libiniparser.so.0
b650a000 b6530000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6540000 b6545000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6556000 b656d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b657e000 b65e9000 r-xp /lib/libm-2.20-2014.11.so
b65fa000 b6600000 r-xp /lib/librt-2.20-2014.11.so
b6611000 b661e000 r-xp /usr/lib/libunwind.so.8.0.1
b6654000 b6778000 r-xp /lib/libc-2.20-2014.11.so
b678d000 b67a6000 r-xp /lib/libgcc_s-4.9.so.1
b67b6000 b6898000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68a9000 b68d3000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68e4000 b6920000 r-xp /usr/lib/libsystemd.so.0.4.0
b6922000 b69a5000 r-xp /usr/lib/libedje.so.1.13.0
b69b8000 b69d6000 r-xp /usr/lib/libecore.so.1.13.0
b69f6000 b6b7d000 r-xp /usr/lib/libevas.so.1.13.0
b6bb2000 b6bc6000 r-xp /lib/libpthread-2.20-2014.11.so
b6bda000 b6e0e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e3d000 b6e41000 r-xp /usr/lib/libsmack.so.1.0.0
b6e51000 b6e58000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e68000 b6e6a000 r-xp /usr/lib/libdlog.so.0.0.0
b6e7a000 b6e7d000 r-xp /usr/lib/libbundle.so.0.1.22
b6e8d000 b6e8f000 r-xp /lib/libdl-2.20-2014.11.so
b6ea0000 b6eb8000 r-xp /usr/lib/libaul.so.0.1.0
b6ecc000 b6ed1000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ee2000 b6eef000 r-xp /usr/lib/liblptcp.so
b6f01000 b6f05000 r-xp /usr/lib/libsys-assert.so
b6f16000 b6f36000 r-xp /lib/ld-2.20-2014.11.so
b6f47000 b6f4c000 r-xp /usr/bin/launchpad-loader
b7e5d000 b827f000 rw-p [heap]
be9b3000 be9d4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2584)
Call Stack Count: 22
 0: _ZN22FoodModifyDeleteButton5clickEv + 0xd (0xb27af434) [/opt/usr/apps/org.example.client/bin/client] + 0xb434
 1: _ZN6Button14callback_clickEPvP10_Eo_OpaqueS0_ + 0x24 (0xb27b8ba5) [/opt/usr/apps/org.example.client/bin/client] + 0x14ba5
 2: (0xb6a5c7ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5ea4219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5ea2fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a5dedd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb6979167) [/usr/lib/libedje.so.1] + 0x57167
 7: (0xb697dd87) [/usr/lib/libedje.so.1] + 0x5bd87
 8: (0xb6979b21) [/usr/lib/libedje.so.1] + 0x57b21
 9: (0xb6979ef1) [/usr/lib/libedje.so.1] + 0x57ef1
10: (0xb697a045) [/usr/lib/libedje.so.1] + 0x58045
11: (0xb69c7d11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb69c3c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69c9a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb69c9c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6ecf2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb3f85909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27b77eb) [/opt/usr/apps/org.example.client/bin/client] + 0x137eb
18: main + 0x40 (0xb27a85b9) [/opt/usr/apps/org.example.client/bin/client] + 0x45b9
19: (0xb6f48bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
20: __libc_start_main + 0x114 (0xb666a4bc) [/lib/libc.so.6] + 0x164bc
21: (0xb6f48eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 1488, appid: com.samsung.browser
04-08 23:36:38.384+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-08 23:36:38.384+0900 E/RESOURCED(  684): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-08 23:36:38.384+0900 E/RESOURCED(  684): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-08 23:36:38.384+0900 E/RESOURCED(  684): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-08 23:36:38.384+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1488)
04-08 23:36:38.384+0900 E/cluster-home(  868): mainmenu-custom-box-impl.cpp: OnClicked(351) >  Success to launch [0][com.samsung.browser]
04-08 23:36:38.394+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1488): preference_inoti.c: _preference_kdb_add_notify(289) > _preference_kdb_add_notify : Key(BookmarkSelectFolderPathTree) does not exist
04-08 23:36:38.394+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1488): preference.c: preference_set_changed_cb(1450) > NO_KEY(0xfef00030) : fail to find given key(BookmarkSelectFolderPathTree)
04-08 23:36:38.394+0900 E/Internet( 1488): preference.cpp: _set_listener(2123) > Can not set [BookmarkSelectFolderPathTree] callback. Required key not available
04-08 23:36:38.424+0900 I/Internet( 1488): browser-fota-upgrade.cpp: init(63) > browser version [2.4-0.0.1]
04-08 23:36:38.484+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 45
04-08 23:36:38.484+0900 W/AUL     (  607): app_signal.c: aul_send_app_group_signal(680) > send_app_group_signal, owner: 1488, child: 2875
04-08 23:36:38.484+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 0
04-08 23:36:38.494+0900 E/RESOURCED(  684): freezer-process.c: freezer_process_pid_set(146) > Cant find process info for 2875
04-08 23:36:38.725+0900 E/EFL     ( 1488): elementary<1488> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8005badf into part 'tizen_vg_shape2'
04-08 23:36:38.755+0900 I/GXT_SIB ( 1488): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-08 23:36:38.785+0900 E/EFL     ( 1488): elementary<1488> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x80070182 into part 'tizen_vg_shape2'
04-08 23:36:38.865+0900 E/EFL     ( 1488): elementary<1488> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x80085a30 into part 'tizen_vg_shape2'
04-08 23:36:38.915+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_create(409) > New handle created[0xb88b38a8]
04-08 23:36:38.915+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: __connection_set_type_changed_callback(170) > Successfully registered(1)
04-08 23:36:38.915+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: __connection_set_ip_changed_callback(255) > Successfully registered(1)
04-08 23:36:38.915+0900 E/Internet( 1488): preference.cpp: create_user_homepage_key(1157) > User Homepage key has already created.
04-08 23:36:38.935+0900 I/APP_CORE( 1488): appcore-efl.c: __do_app(514) > [APP 1488] Event: RESET State: CREATED
04-08 23:36:38.935+0900 I/CAPI_APPFW_APPLICATION( 1488): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-08 23:36:38.935+0900 I/Internet( 1488): main.cpp: __br_app_reset(1190) > 
04-08 23:36:38.935+0900 E/Internet( 1488): browser.cpp: terminate_app_launch_request(2250) > m_appControl is NULL
04-08 23:36:38.935+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_get_type(463) > Connected Network = 2
04-08 23:36:38.955+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:38.955+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:38.965+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:38.965+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:38.965+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.browser/res/edje/HD_720x1280/z3/browser-view-hd-z3.edj, group webview-layout has a non-fixed part 'elm.swallow.top-tool-bar'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-08 23:36:38.985+0900 W/CAPI_APPFW_APP_CONTROL( 1488): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-08 23:36:38.985+0900 W/CAPI_APPFW_APP_CONTROL( 1488): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-08 23:36:38.985+0900 W/CAPI_APPFW_APP_CONTROL( 1488): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-08 23:36:38.985+0900 W/CAPI_APPFW_APP_CONTROL( 1488): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-08 23:36:38.985+0900 E/Internet( 1488): main.cpp: _supported_mime_type(1068) > mime_type is NULL
04-08 23:36:38.985+0900 E/Internet( 1488): browser-view.cpp: launch(447) > url is invalid
04-08 23:36:38.985+0900 I/PRIVACY-MANAGER-CLIENT( 1488): SocketClient.cpp: SocketClient(37) > Client created
04-08 23:36:38.985+0900 I/PRIVACY-MANAGER-CLIENT( 1488): SocketClient.cpp: SocketClient(37) > Client created
04-08 23:36:38.985+0900 I/PRIVACY-MANAGER-CLIENT( 1488): SocketClient.cpp: connect(62) > Client connected
04-08 23:36:38.985+0900 I/PRIVACY-MANAGER-SERVER(  938): SocketService.cpp: mainloop(230) > Got incoming connection
04-08 23:36:38.985+0900 I/PRIVACY-MANAGER-CLIENT( 1488): SocketClient.cpp: disconnect(72) > Client disconnected
04-08 23:36:39.015+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:39.015+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:39.035+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [com.samsun] 
04-08 23:36:39.035+0900 I/Tizen::System( 1246): (273) > Current App[com.samsun] is already actived.
04-08 23:36:39.035+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-08 23:36:39.115+0900 I/UXT     ( 2875): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-08 23:36:39.125+0900 E/UXT     ( 2875): uxt_theme.c: _set_changeable_ui_data(129) > failed to get ecore_evas list.
04-08 23:36:39.125+0900 E/UXT     ( 2875): uxt_theme.c: _set_changeable_ui_data(129) > failed to get ecore_evas list.
04-08 23:36:39.135+0900 I/BROWSER_PROVIDER( 2882): browser-provider-main.c: __bp_accept_socket_new(138) > listen systemd socket:3
04-08 23:36:39.135+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: bp_thread_requests_manager(698) > new-client[TABS:1590642353] slot:0 sock:7
04-08 23:36:39.135+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(TABS:1590642353) sock:7 req(DUP_ORDER_IDS:-1)
04-08 23:36:39.145+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(TABS:1590642353) sock:7 req(GET_INFO_OFFSET:1907916453)
04-08 23:36:39.145+0900 E/EFL     ( 1488): elementary<1488> elm_widget.c:1147 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8009c2e4 Ewk_View). Elementary widget's parent should be an elementary widget.
04-08 23:36:39.145+0900 E/EFL     ( 1488): <1488> elm_main.c:1685 elm_object_top_widget_get() safety check failed: obj == NULL
04-08 23:36:39.145+0900 E/EFL     ( 1488): elementary<1488> elm_widget.c:1147 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8009c2e4 Ewk_View). Elementary widget's parent should be an elementary widget.
04-08 23:36:39.145+0900 E/EFL     ( 1488): elementary<1488> elm_widget.c:1147 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8009c2e4 Ewk_View). Elementary widget's parent should be an elementary widget.
04-08 23:36:39.155+0900 E/EFL     ( 1488): elementary<1488> elm_widget.c:1147 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8009c2e4 Ewk_View). Elementary widget's parent should be an elementary widget.
04-08 23:36:39.205+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_create(409) > New handle created[0xb8925c40]
04-08 23:36:39.205+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: __connection_set_ip_changed_callback(255) > Successfully registered(2)
04-08 23:36:39.205+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: __connection_set_proxy_changed_callback(340) > Successfully registered(1)
04-08 23:36:39.215+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_get_type(463) > Connected Network = 2
04-08 23:36:39.265+0900 I/Internet( 1488): webview.cpp: activate(2444) > 
04-08 23:36:39.265+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:39.265+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:39.265+0900 W/CAPI_APPFW_APP_CONTROL( 1488): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-08 23:36:39.265+0900 E/Internet( 1488): mdm-manager.cpp: register_policy(254) > mdm_get_service() is failed [0xffffffff]
04-08 23:36:39.285+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_get_wifi_state(706) > Wi-Fi state: 2
04-08 23:36:39.295+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.295+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.295+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.295+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.295+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.295+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.295+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.295+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.295+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.295+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.305+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:39.305+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:39.315+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:39.315+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:39.315+0900 I/AUL     ( 2875): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/WebProcess, ret : 0
04-08 23:36:39.315+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.315+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.315+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:39.325+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:39.325+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:39.325+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.325+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:39.325+0900 E/EFL     ( 1488): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:39.335+0900 W/APP_CORE( 1488): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000003
04-08 23:36:39.335+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-08 23:36:39.345+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-main.c: __qas_accept_socket(235) > listen systemd socket:3
04-08 23:36:39.345+0900 W/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-main.c: qas_main_thread(225) > qas_main_thread end
04-08 23:36:39.345+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-request-handler.c: _initialize(239) > Invalid Location data: latitude = 100.000000 longitude = 200.000000
04-08 23:36:39.355+0900 E/EFL     ( 1488): edje<1488> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.browser/res/edje/HD_720x1280/z3/browser-view-hd-z3.edj, group webview-layout has a non-fixed part 'elm.swallow.top-tool-bar'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(41) > +++++++++++++++++++++++++++++++++++++++++++++++++
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(42) > [INFO] Server base_url    https://secureapi.samqaicongen.com/QuickAccess/getSubRegionalItems
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(43) > [INFO] Server Id          1
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(44) > [INFO] Server wait_time   300000
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(45) > [INFO] Server retry_count 3
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(46) > [INFO] Server fall_back   0
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(47) > +++++++++++++++++++++++++++++++++++++++++++++++++
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(41) > +++++++++++++++++++++++++++++++++++++++++++++++++
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(42) > [INFO] Server base_url    https://secureroute53.samqaicongen.com/QuickAccess/getSubRegionalItems
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(43) > [INFO] Server Id          2
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(44) > [INFO] Server wait_time   300000
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(45) > [INFO] Server retry_count 3
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(46) > [INFO] Server fall_back   1
04-08 23:36:39.365+0900 I/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-server-data.c: print_server_data(47) > +++++++++++++++++++++++++++++++++++++++++++++++++
04-08 23:36:39.365+0900 E/VCONF   ( 2894): vconf.c: vconf_get_str(2893) > The type(41) of keynode(db/csc/operator) is not STR
04-08 23:36:39.365+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:39.365+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:39.365+0900 E/Internet( 1488): most-visited-manager.cpp: view_resize_need(623) > Most_visited_view is NULL
04-08 23:36:39.365+0900 I/Internet( 1488): main-view.cpp: show_url_bar(439) > 1
04-08 23:36:39.425+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-08 23:36:39.425+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-08 23:36:39.425+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-08 23:36:39.425+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.325
04-08 23:36:39.425+0900 I/Tizen::App( 1246): (499) > LaunchedApp(com.samsung.browser)
04-08 23:36:39.425+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for com.samsung.browser, 1488.
04-08 23:36:39.435+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1488) status(0)
04-08 23:36:39.435+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1488) status(0)
04-08 23:36:39.435+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-08 23:36:39.435+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-08 23:36:39.435+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-08 23:36:39.435+0900 I/APP_CORE( 1488): appcore-efl.c: __do_app(514) > [APP 1488] Event: RESUME State: CREATED
04-08 23:36:39.435+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1488) status(3)
04-08 23:36:39.435+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-08 23:36:39.435+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-08 23:36:39.435+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.browser(1488)
04-08 23:36:39.435+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1488, appid: com.samsung.browser, status: fg
04-08 23:36:39.455+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-08 23:36:39.455+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-08 23:36:39.455+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-08 23:36:39.465+0900 I/APP_CORE( 1488): appcore-efl.c: __do_app(623) > Legacy lifecycle: 1
04-08 23:36:39.495+0900 I/CAPI_NETWORK_CONNECTION( 2894): connection.c: connection_create(409) > New handle created[0xb573f110]
04-08 23:36:39.495+0900 I/CAPI_NETWORK_CONNECTION( 2894): connection.c: connection_destroy(427) > Destroy handle: 0xb573f110
04-08 23:36:39.515+0900 I/Internet( 1488): webview.cpp: __back_forward_list_changed_cb(5716) > 
04-08 23:36:39.515+0900 I/Internet( 1488): webview.cpp: __policy_navigation_decide_cb(5363) > 
04-08 23:36:39.525+0900 I/Internet( 1488): webview.cpp: __policy_navigation_decide_cb(5422) > Main frame
04-08 23:36:39.545+0900 I/Internet( 1488): webview.cpp: __load_started_cb(3452) > 
04-08 23:36:39.555+0900 I/AUL     ( 2875): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/WebProcess, ret : 0
04-08 23:36:39.565+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_get_wifi_state(706) > Wi-Fi state: 2
04-08 23:36:39.565+0900 I/Internet( 1488): webview.cpp: __url_changed_cb(3801) > 
04-08 23:36:39.565+0900 E/Internet( 1488): browser-view.cpp: deactivate_most_visited_view(1973) > Already deactivateed
04-08 23:36:39.635+0900 E/EFL     ( 2875): edje<2875> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/share/edje/webkit.edj, group webkit/widget/combo has a non-fixed part 'bt_combo_clipper'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-08 23:36:39.686+0900 E/EFL     ( 2875): edje<2875> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/share/edje/webkit.edj, group webkit/widget/spinner has a non-fixed part 'up_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-08 23:36:39.696+0900 E/TBM     ( 2875): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-08 23:36:39.706+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.326
04-08 23:36:40.236+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-request-server.c: qas_parse_json_header(293) > Next update duration: 86400
04-08 23:36:40.256+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db-interface.c: qas_get_string_for_url_from_db(508) > Error : QAS_ERROR_ID_NOT_FOUND
04-08 23:36:40.296+0900 I/CAPI_NETWORK_CONNECTION( 2894): connection.c: connection_create(409) > New handle created[0xb57a6698]
04-08 23:36:40.296+0900 I/CAPI_NETWORK_CONNECTION( 2894): connection.c: connection_destroy(427) > Destroy handle: 0xb57a6698
04-08 23:36:40.356+0900 I/UXT     ( 2896): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-08 23:36:40.376+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-download-icon.c: qas_get_quickaccess_icons(231) > Icon last modified time is not changed so not downloading icon
04-08 23:36:40.376+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-download-icon.c: qas_get_quickaccess_icons(231) > Icon last modified time is not changed so not downloading icon
04-08 23:36:40.376+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-download-icon.c: qas_get_quickaccess_icons(231) > Icon last modified time is not changed so not downloading icon
04-08 23:36:40.376+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-download-icon.c: qas_get_quickaccess_icons(231) > Icon last modified time is not changed so not downloading icon
04-08 23:36:40.376+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-download-icon.c: qas_get_quickaccess_icons(231) > Icon last modified time is not changed so not downloading icon
04-08 23:36:40.376+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-download-icon.c: qas_get_quickaccess_icons(231) > Icon last modified time is not changed so not downloading icon
04-08 23:36:40.376+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-download-icon.c: qas_get_quickaccess_icons(231) > Icon last modified time is not changed so not downloading icon
04-08 23:36:40.376+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-utils.c: remove_file(240) > Failed to remove file in the path
04-08 23:36:40.396+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_create_quick_access_item(438) > Before write finalize, sqlite response code 101
04-08 23:36:40.406+0900 E/TBM     ( 2896): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-08 23:36:40.406+0900 I/MALI    ( 2896): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=2896   open drm_fd=30 
04-08 23:36:40.416+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.446+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.466+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.486+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.506+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.536+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.536+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db-interface.c: update_quickaccess_icon_to_db(262) > NULL check::item->ps_qas_icon_list
04-08 23:36:40.546+0900 E/EFL     ( 2896): edje<2896> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:40.546+0900 E/EFL     ( 2896): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:40.546+0900 E/EFL     ( 2896): edje<2896> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:40.546+0900 E/EFL     ( 2896): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:40.546+0900 E/EFL     ( 2896): edje<2896> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:40.546+0900 E/EFL     ( 2896): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:40.566+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.586+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.616+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.636+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.636+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db-interface.c: update_quickaccess_icon_to_db(262) > NULL check::item->ps_qas_icon_list
04-08 23:36:40.847+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.937+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:40.987+0900 I/Internet( 1488): webview.cpp: __policy_response_decide_cb(5554) > 
04-08 23:36:41.007+0900 I/Internet( 1488): webview.cpp: __load_committed_cb(3566) > 
04-08 23:36:41.017+0900 E/Internet( 1488): csrfw-manager.cpp: twp_url_lookup(353) > failed to get rating
04-08 23:36:41.037+0900 I/Internet( 1488): webview.cpp: __title_changed_cb(3849) > 
04-08 23:36:41.057+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.177+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.177+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db-interface.c: update_quickaccess_icon_to_db(262) > NULL check::item->ps_qas_icon_list
04-08 23:36:41.197+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.217+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.237+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.257+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.257+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db-interface.c: update_quickaccess_icon_to_db(262) > NULL check::item->ps_qas_icon_list
04-08 23:36:41.287+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.307+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.327+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.357+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.357+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db-interface.c: update_quickaccess_icon_to_db(262) > NULL check::item->ps_qas_icon_list
04-08 23:36:41.377+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.387+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.407+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.427+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.427+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db-interface.c: update_quickaccess_icon_to_db(262) > NULL check::item->ps_qas_icon_list
04-08 23:36:41.437+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.447+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.467+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.477+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.477+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db-interface.c: update_quickaccess_icon_to_db(262) > NULL check::item->ps_qas_icon_list
04-08 23:36:41.497+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.507+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.517+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.527+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-db.c: qas_db_column_replace(491) > Before write finalize, sqlite response code 101
04-08 23:36:41.637+0900 E/BROWSER_QUICKACCESS_SERVICE( 2894): quickaccess-service-request-handler.c: _qas_get_full_ids(46) > offset == QUICK_ACCESS_ADAPTOR_O_DIRTY
04-08 23:36:41.878+0900 W/AUL     ( 2967): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-08 23:36:41.888+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
04-08 23:36:41.898+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-08 23:36:41.908+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-08 23:36:41.908+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-08 23:36:41.908+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 2967
04-08 23:36:41.908+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-08 23:36:41.918+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-08 23:36:41.918+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-08 23:36:41.918+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-08 23:36:41.918+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-08 23:36:41.918+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-08 23:36:41.938+0900 I/abc     ( 2584): abc
04-08 23:36:41.938+0900 I/CAPI_APPFW_APPLICATION( 2584): app_main.c: ui_app_main(789) > app_efl_main
04-08 23:36:41.938+0900 I/CAPI_APPFW_APPLICATION( 2584): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-08 23:36:42.008+0900 E/TBM     ( 2584): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-08 23:36:42.018+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2584, appid: org.example.client
04-08 23:36:42.018+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-08 23:36:42.018+0900 W/AUL     ( 2967): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2584)
04-08 23:36:42.028+0900 E/RESOURCED(  684): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.client
04-08 23:36:42.028+0900 E/Internet( 1488): quick-access-view.cpp: remove_single_item_on_grid(366) > m_normal_mode_layout is NULL
04-08 23:36:42.078+0900 E/Internet( 1488): quick-access-view.cpp: append_single_item_on_grid(292) > QA gengrid is NULL
04-08 23:36:42.088+0900 E/Internet( 1488): quick-access-view.cpp: update_single_item_on_grid(342) > m_normal_mode_layout is NULL
04-08 23:36:42.098+0900 E/Internet( 1488): quick-access-view.cpp: update_single_item_on_grid(342) > m_normal_mode_layout is NULL
04-08 23:36:42.118+0900 E/Internet( 1488): quick-access-view.cpp: update_single_item_on_grid(342) > m_normal_mode_layout is NULL
04-08 23:36:42.128+0900 E/Internet( 1488): quick-access-view.cpp: update_single_item_on_grid(342) > m_normal_mode_layout is NULL
04-08 23:36:42.138+0900 E/Internet( 1488): quick-access-view.cpp: update_single_item_on_grid(342) > m_normal_mode_layout is NULL
04-08 23:36:42.158+0900 E/Internet( 1488): quick-access-view.cpp: update_single_item_on_grid(342) > m_normal_mode_layout is NULL
04-08 23:36:42.168+0900 E/Internet( 1488): quick-access-view.cpp: update_single_item_on_grid(342) > m_normal_mode_layout is NULL
04-08 23:36:42.168+0900 E/Internet( 1488): quick-access-view.cpp: remove_single_item_on_grid(366) > m_normal_mode_layout is NULL
04-08 23:36:42.248+0900 E/Internet( 1488): quick-access-view.cpp: append_single_item_on_grid(292) > QA gengrid is NULL
04-08 23:36:42.358+0900 D/basicui ( 2584): successed to load edc file
04-08 23:36:42.388+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:42.388+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:42.418+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-08 23:36:42.418+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-08 23:36:42.428+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-08 23:36:42.428+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-08 23:36:42.428+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-08 23:36:42.428+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-08 23:36:42.428+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-08 23:36:42.438+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-08 23:36:42.458+0900 I/MY_LOG  ( 2584): change
04-08 23:36:42.508+0900 I/APP_CORE( 2584): appcore-efl.c: __do_app(514) > [APP 2584] Event: RESET State: CREATED
04-08 23:36:42.508+0900 I/CAPI_APPFW_APPLICATION( 2584): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-08 23:36:42.518+0900 E/EFL     ( 2584): edje<2584> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:42.518+0900 E/EFL     ( 2584): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:42.518+0900 E/EFL     ( 2584): edje<2584> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:42.518+0900 E/EFL     ( 2584): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:42.528+0900 E/EFL     ( 2584): edje<2584> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:42.528+0900 E/EFL     ( 2584): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:42.528+0900 W/APP_CORE( 2584): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-08 23:36:42.538+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-08 23:36:42.678+0900 I/APP_CORE( 1488): appcore-efl.c: __do_app(514) > [APP 1488] Event: PAUSE State: RUNNING
04-08 23:36:42.678+0900 I/CAPI_APPFW_APPLICATION( 1488): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-08 23:36:42.678+0900 I/Internet( 1488): main.cpp: __br_app_pause(672) > 
04-08 23:36:42.678+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_get_type(463) > Connected Network = 2
04-08 23:36:42.678+0900 W/UI_GADGET( 1488): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
04-08 23:36:42.678+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1488) status(4)
04-08 23:36:42.678+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.browser(1488)
04-08 23:36:42.678+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1488, appid: com.samsung.browser, status: bg
04-08 23:36:42.688+0900 I/APP_CORE( 2584): appcore-efl.c: __do_app(514) > [APP 2584] Event: RESUME State: CREATED
04-08 23:36:42.688+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(2584) status(3)
04-08 23:36:42.688+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-08 23:36:42.688+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-08 23:36:42.688+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(2584)
04-08 23:36:42.688+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2584, appid: org.example.client, status: fg
04-08 23:36:42.708+0900 I/APP_CORE( 2584): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-08 23:36:42.708+0900 I/APP_CORE( 2584): appcore-efl.c: __do_app(625) > [APP 2584] Initial Launching, call the resume_cb
04-08 23:36:42.708+0900 I/CAPI_APPFW_APPLICATION( 2584): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-08 23:36:42.708+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 1488): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 26
04-08 23:36:42.708+0900 E/APP_CORE( 1488): appcore-efl.c: _capture_and_make_file(1619) > win[6000003] widget[720] height[1280]
04-08 23:36:42.708+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
04-08 23:36:43.079+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.331
04-08 23:36:43.079+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-08 23:36:43.079+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 2584.
04-08 23:36:43.079+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(2584) status(0)
04-08 23:36:44.020+0900 I/UXT     ( 2989): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-08 23:36:44.420+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-08 23:36:45.401+0900 E/EFL     ( 2584): ecore_x<2584> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3342591
04-08 23:36:45.481+0900 I/Internet( 1488): webview.cpp: __policy_navigation_decide_cb(5363) > 
04-08 23:36:45.491+0900 I/Internet( 1488): webview.cpp: __policy_response_decide_cb(5554) > 
04-08 23:36:45.511+0900 E/EFL     ( 2584): ecore_x<2584> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3342701
04-08 23:36:45.561+0900 D/basicui ( 2584): successed to load edc file
04-08 23:36:45.591+0900 I/MY_LOG  ( 2584): change
04-08 23:36:45.591+0900 I/MY_LOG  ( 2584): change
04-08 23:36:45.621+0900 E/VCONF   ( 2584): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-08 23:36:45.621+0900 E/VCONF   ( 2584): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-08 23:36:45.621+0900 E/VCONF   ( 2584): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-08 23:36:45.621+0900 E/VCONF   ( 2584): vconf.c: vconf_get_bool(2729) > vconf_get_bool(2584) : db/ise/keysound error
04-08 23:36:45.621+0900 E/VCONF   ( 2584): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-08 23:36:45.621+0900 E/VCONF   ( 2584): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-08 23:36:46.182+0900 I/Internet( 1488): webview.cpp: __load_finished_cb(4956) > 
04-08 23:36:46.182+0900 E/WEBKIT  ( 1488): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(228) > ERROR: Error on selecting formdata from database
04-08 23:36:46.192+0900 E/Internet( 1488): browser-view.cpp: deactivate_quick_access_view(1784) > Already deactivateed
04-08 23:36:46.192+0900 E/Internet( 1488): quick-access-manager.cpp: do_load_finished_jobs(2428) > Jobs done for quick access
04-08 23:36:46.762+0900 E/EFL     ( 2584): ecore_x<2584> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3343955
04-08 23:36:46.762+0900 I/MY_LOG  ( 2584): Button pressed
04-08 23:36:46.853+0900 E/EFL     ( 2584): ecore_x<2584> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3344044
04-08 23:36:46.863+0900 I/MY_LOG  ( 2584): Button unpressed
04-08 23:36:47.113+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2584 pgid = 2584
04-08 23:36:47.113+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(2584)
04-08 23:36:47.113+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:47.133+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1488) status(3)
04-08 23:36:47.133+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-08 23:36:47.133+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-08 23:36:47.133+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.browser(1488)
04-08 23:36:47.133+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1488, appid: com.samsung.browser, status: fg
04-08 23:36:47.163+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-08 23:36:47.163+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-08 23:36:47.163+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-08 23:36:47.173+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 2584
04-08 23:36:47.173+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[2584] terminate event is forwarded
04-08 23:36:47.173+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-08 23:36:47.173+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 2584, ]
04-08 23:36:47.173+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-08 23:36:47.173+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-08 23:36:47.173+0900 I/Tizen::App( 1246): (512) > Not registered pid(2584)
04-08 23:36:47.173+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-08 23:36:47.173+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-08 23:36:47.173+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2584
04-08 23:36:47.173+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2584
04-08 23:36:47.183+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-08 23:36:47.183+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 2584.
04-08 23:36:47.203+0900 W/CRASH_MANAGER( 3042): worker.c: worker_job(1199) > 1102584636c69149166220
