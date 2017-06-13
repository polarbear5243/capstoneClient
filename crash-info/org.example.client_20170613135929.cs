S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 15215
Date: 2017-06-13 13:59:29+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb276165a

Register Information
r0   = 0xb9126df0, r1   = 0xb9122d38
r2   = 0xb9122d38, r3   = 0xb9126df0
r4   = 0xb3f50a3c, r5   = 0xbeb8b484
r6   = 0x00000001, r7   = 0xbeb8b348
r8   = 0xbeb8b478, r9   = 0xb8f7c9d0
r10  = 0xbeb8b498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbeb8b2ec
lr   = 0xb27615d7, pc   = 0xb276165a
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     67832 KB
Buffers:     61124 KB
Cached:     225492 KB
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
PID = 15215 TID = 15215
15215 15220 15273 15276 

Maps Information
b1312000 b131a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b132c000 b1b2b000 rw-p [stack:15276]
b1b2b000 b1b2c000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b3c000 b1b50000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b64000 b1b65000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b75000 b1b78000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b89000 b1b8a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b9a000 b1b9c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bac000 b1bae000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bbe000 b1bce000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bde000 b1bea000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bfc000 b23fb000 rw-p [stack:15273]
b272c000 b2733000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2746000 b274c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b275c000 b278c000 r-xp /opt/usr/apps/org.example.client/bin/client
b28d5000 b29b8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29ef000 b2a17000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a29000 b3228000 rw-p [stack:15220]
b3228000 b322a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b323a000 b3244000 r-xp /lib/libnss_files-2.20-2014.11.so
b3255000 b325e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b326f000 b3280000 r-xp /lib/libnsl-2.20-2014.11.so
b3293000 b3299000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32aa000 b32ab000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32d3000 b32da000 r-xp /usr/lib/libminizip.so.1.0.0
b32ea000 b32ef000 r-xp /usr/lib/libstorage.so.0.1
b32ff000 b335e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3374000 b3388000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3398000 b33dc000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33ec000 b33f4000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3404000 b3434000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3447000 b3500000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3514000 b3567000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3578000 b3593000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35a3000 b3664000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3677000 b3687000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3697000 b36a4000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b5000 b36bc000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36cc000 b370d000 r-xp /usr/lib/libmdm.so.1.2.12
b371d000 b3725000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3734000 b3744000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3765000 b37c5000 r-xp /usr/lib/libasound.so.2.0.0
b37d7000 b37da000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37ea000 b37ed000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37fd000 b3802000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3812000 b3813000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3823000 b382e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3842000 b3849000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3859000 b385f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b386f000 b3874000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3884000 b389f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38af000 b38b6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c6000 b38c9000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38da000 b3908000 r-xp /usr/lib/libidn.so.11.5.44
b3918000 b392e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b393f000 b3949000 r-xp /usr/lib/libcares.so.2.1.0
b3959000 b3963000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3973000 b3975000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3985000 b3986000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3996000 b399a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39ab000 b39d3000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e4000 b3a0d000 r-xp /usr/lib/libturbojpeg.so
b3a2d000 b3a33000 r-xp /usr/lib/libgif.so.4.1.6
b3a43000 b3a89000 r-xp /usr/lib/libcurl.so.4.3.0
b3a9a000 b3abb000 r-xp /usr/lib/libexif.so.12.3.3
b3ad6000 b3aeb000 r-xp /usr/lib/libtts.so
b3afc000 b3b04000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b14000 b3bda000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bfa000 b3cf2000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d11000 b3ddf000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df6000 b3df8000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e08000 b3e0e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e1e000 b3e41000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e52000 b3e54000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e64000 b3e66000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e77000 b3e7c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e93000 b3e95000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea5000 b3eac000 r-xp /usr/lib/libsensord-share.so
b3ebc000 b3ed4000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee5000 b3ee8000 r-xp /usr/lib/libXv.so.1.0.0
b3ef8000 b3efd000 r-xp /usr/lib/libutilX.so.1.1.0
b3f0d000 b3f12000 r-xp /usr/lib/libappcore-common.so.1.1
b3f22000 b3f29000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f3c000 b3f40000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f51000 b402f000 r-xp /usr/lib/libCOREGL.so.4.0
b404f000 b4052000 r-xp /usr/lib/libuuid.so.1.3.0
b4062000 b4079000 r-xp /usr/lib/libblkid.so.1.1.0
b408a000 b408c000 r-xp /usr/lib/libXau.so.6.0.0
b409c000 b40e3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f5000 b40fb000 r-xp /usr/lib/libjson-c.so.2.0.1
b410c000 b4110000 r-xp /usr/lib/libogg.so.0.7.1
b4120000 b4142000 r-xp /usr/lib/libvorbis.so.0.4.3
b4152000 b4236000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4252000 b4255000 r-xp /usr/lib/libEGL.so.1.4
b4266000 b426c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b427c000 b427e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b428e000 b429b000 r-xp /usr/lib/libGLESv2.so.2.0
b42ac000 b430e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4323000 b433b000 r-xp /usr/lib/libmount.so.1.1.0
b434d000 b4361000 r-xp /usr/lib/libxcb.so.1.1.0
b4371000 b4378000 r-xp /lib/libcrypt-2.20-2014.11.so
b43b0000 b43b2000 r-xp /usr/lib/libiri.so
b43c2000 b43cd000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43de000 b4414000 r-xp /usr/lib/libpulse.so.0.16.2
b4425000 b4468000 r-xp /usr/lib/libsndfile.so.1.0.25
b447d000 b4492000 r-xp /lib/libexpat.so.1.5.2
b44a4000 b4562000 r-xp /usr/lib/libcairo.so.2.11200.14
b4576000 b457e000 r-xp /usr/lib/libdrm.so.2.4.0
b458e000 b4591000 r-xp /usr/lib/libdri2.so.0.0.0
b45a1000 b45ef000 r-xp /usr/lib/libssl.so.1.0.0
b4604000 b4610000 r-xp /usr/lib/libeeze.so.1.13.0
b4621000 b462a000 r-xp /usr/lib/libethumb.so.1.13.0
b463a000 b463d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b464d000 b4804000 r-xp /usr/lib/libcrypto.so.1.0.0
b55ef000 b55f8000 r-xp /usr/lib/libXi.so.6.1.0
b5608000 b560a000 r-xp /usr/lib/libXgesture.so.7.0.0
b561a000 b561e000 r-xp /usr/lib/libXtst.so.6.1.0
b562e000 b5634000 r-xp /usr/lib/libXrender.so.1.3.0
b5644000 b564a000 r-xp /usr/lib/libXrandr.so.2.2.0
b565a000 b565c000 r-xp /usr/lib/libXinerama.so.1.0.0
b566d000 b5670000 r-xp /usr/lib/libXfixes.so.3.1.0
b5680000 b568b000 r-xp /usr/lib/libXext.so.6.4.0
b569b000 b569d000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ad000 b56af000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56bf000 b57a1000 r-xp /usr/lib/libX11.so.6.3.0
b57b5000 b57bc000 r-xp /usr/lib/libXcursor.so.1.0.2
b57cc000 b57e4000 r-xp /usr/lib/libudev.so.1.6.0
b57e6000 b57e9000 r-xp /lib/libattr.so.1.1.0
b57f9000 b5819000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b581a000 b581f000 r-xp /usr/lib/libffi.so.6.0.2
b5830000 b5848000 r-xp /lib/libz.so.1.2.8
b5858000 b585a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b586a000 b593f000 r-xp /usr/lib/libxml2.so.2.9.2
b5954000 b59ef000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a0b000 b5a0e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a1e000 b5a37000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a48000 b5a59000 r-xp /lib/libresolv-2.20-2014.11.so
b5a6d000 b5ae7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5afc000 b5afe000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b0e000 b5b15000 r-xp /usr/lib/libembryo.so.1.13.0
b5b25000 b5b2f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b40000 b5b58000 r-xp /usr/lib/libpng12.so.0.50.0
b5b69000 b5b8c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bad000 b5bc1000 r-xp /usr/lib/libector.so.1.13.0
b5bd2000 b5bea000 r-xp /usr/lib/liblua-5.1.so
b5bfb000 b5c52000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c66000 b5c8e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5c9f000 b5cb2000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cc3000 b5cfd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0e000 b5d1c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d2c000 b5d34000 r-xp /usr/lib/libtbm.so.1.0.0
b5d44000 b5d51000 r-xp /usr/lib/libeio.so.1.13.0
b5d61000 b5d63000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d73000 b5d78000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d88000 b5d9f000 r-xp /usr/lib/libefreet.so.1.13.0
b5db1000 b5dd1000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de1000 b5e01000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e03000 b5e09000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e19000 b5e2a000 r-xp /usr/lib/libemotion.so.1.13.0
b5e3b000 b5e42000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e52000 b5e61000 r-xp /usr/lib/libeo.so.1.13.0
b5e72000 b5e84000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e95000 b5e9a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eaa000 b5ec3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed3000 b5ef0000 r-xp /usr/lib/libeet.so.1.13.0
b5f09000 b5f51000 r-xp /usr/lib/libeina.so.1.13.0
b5f62000 b5f72000 r-xp /usr/lib/libefl.so.1.13.0
b5f83000 b6068000 r-xp /usr/lib/libicuuc.so.51.1
b6085000 b61c5000 r-xp /usr/lib/libicui18n.so.51.1
b61dc000 b6214000 r-xp /usr/lib/libecore_x.so.1.13.0
b6226000 b6229000 r-xp /lib/libcap.so.2.21
b6239000 b6262000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6273000 b627a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b628c000 b62c3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d4000 b63bf000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d2000 b644b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b645d000 b6462000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6472000 b647c000 r-xp /usr/lib/libvconf.so.0.2.45
b648c000 b648e000 r-xp /usr/lib/libvasum.so.0.3.1
b649e000 b64a0000 r-xp /usr/lib/libttrace.so.1.1
b64b0000 b64b3000 r-xp /usr/lib/libiniparser.so.0
b64c3000 b64e9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64f9000 b64fe000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650f000 b6526000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6537000 b65a2000 r-xp /lib/libm-2.20-2014.11.so
b65b3000 b65b9000 r-xp /lib/librt-2.20-2014.11.so
b65ca000 b65d7000 r-xp /usr/lib/libunwind.so.8.0.1
b660d000 b6731000 r-xp /lib/libc-2.20-2014.11.so
b6746000 b675f000 r-xp /lib/libgcc_s-4.9.so.1
b676f000 b6851000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6862000 b688c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b689d000 b68d9000 r-xp /usr/lib/libsystemd.so.0.4.0
b68db000 b695e000 r-xp /usr/lib/libedje.so.1.13.0
b6971000 b698f000 r-xp /usr/lib/libecore.so.1.13.0
b69af000 b6b36000 r-xp /usr/lib/libevas.so.1.13.0
b6b6b000 b6b7f000 r-xp /lib/libpthread-2.20-2014.11.so
b6b93000 b6dc7000 r-xp /usr/lib/libelementary.so.1.13.0
b6df6000 b6dfa000 r-xp /usr/lib/libsmack.so.1.0.0
b6e0a000 b6e11000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e21000 b6e23000 r-xp /usr/lib/libdlog.so.0.0.0
b6e33000 b6e36000 r-xp /usr/lib/libbundle.so.0.1.22
b6e46000 b6e48000 r-xp /lib/libdl-2.20-2014.11.so
b6e59000 b6e71000 r-xp /usr/lib/libaul.so.0.1.0
b6e85000 b6e8a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e9b000 b6ea8000 r-xp /usr/lib/liblptcp.so
b6eba000 b6ebe000 r-xp /usr/lib/libsys-assert.so
b6ecf000 b6eef000 r-xp /lib/ld-2.20-2014.11.so
b6f00000 b6f05000 r-xp /usr/bin/launchpad-loader
b8f0e000 b9153000 rw-p [heap]
beb6b000 beb8c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15215)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb276165a) [/opt/usr/apps/org.example.client/bin/client] + 0x565a
 1:  + 0x0 (0xb27615d7) [/opt/usr/apps/org.example.client/bin/client] + 0x55d7
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb27613a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb277a5db) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5db
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb277a751) [/opt/usr/apps/org.example.client/bin/client] + 0x1e751
 5: (0xb3f3e4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6e88203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3f3e909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb277aadb) [/opt/usr/apps/org.example.client/bin/client] + 0x1eadb
 9: main + 0x40 (0xb2761129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6f01bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb66234bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6f01eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
tinfo(496) > Id:Count = 45 1
06-13 13:59:13.121+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 13:59:13.121+0900 E/rpm-installer(15133): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 13:59:13.131+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:13.131+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:13.131+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 13:59:13.131+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 13:59:13.131+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-13 13:59:13.141+0900 E/rpm-installer(15133): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 13:59:13.161+0900 E/rpm-installer(15133): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 13:59:13.161+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:13.161+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 13:59:13.161+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:13.161+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 13:59:13.161+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-13 13:59:14.793+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 13:59:15.003+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:15.003+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 13:59:15.003+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:15.003+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 13:59:15.003+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 13:59:15.003+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 13:59:15.003+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 13:59:15.003+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 13:59:15.013+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 13:59:15.033+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15133]
06-13 13:59:15.033+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 13:59:15.043+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 13:59:15.043+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 13:59:15.053+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 13:59:15.053+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 13:59:15.053+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 13:59:15.053+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 13:59:15.053+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 13:59:15.053+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-13 13:59:15.053+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 13:59:15.063+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 13:59:15.063+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 13:59:15.063+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 13:59:15.063+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (131) > Enter
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 13:59:15.073+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 13:59:15.073+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 13:59:15.073+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 13:59:15.073+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 13:59:15.083+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 13:59:16.795+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 13:59:16.795+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 13:59:19.347+0900 W/AUL     (15188): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:59:19.347+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:19.357+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 13:59:19.367+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 13:59:19.367+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:59:19.367+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 15188
06-13 13:59:19.367+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:59:19.377+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:59:19.377+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:19.377+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:59:19.377+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:59:19.377+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:59:19.397+0900 I/abc     (14613): abc
06-13 13:59:19.397+0900 I/CAPI_APPFW_APPLICATION(14613): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:59:19.397+0900 I/CAPI_APPFW_APPLICATION(14613): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:59:19.427+0900 E/TBM     (14613): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:59:19.477+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14613, appid: org.example.client
06-13 13:59:19.477+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:59:19.487+0900 W/AUL     (15188): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14613)
06-13 13:59:19.878+0900 W/CRASH_MANAGER(15203): worker.c: worker_job(1199) > 0414613636c691497329959
06-13 13:59:20.478+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:59:20.478+0900 W/AUL_AMD (  607): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-13 13:59:20.508+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14613 pgid = 14613
06-13 13:59:20.508+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14613)
06-13 13:59:20.508+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 14613.
06-13 13:59:20.518+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1547
06-13 13:59:20.568+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:59:20.568+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:59:20.568+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:59:20.568+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 14613.
06-13 13:59:20.568+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14613
06-13 13:59:20.568+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14613
06-13 13:59:20.568+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14613
06-13 13:59:20.588+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1548
06-13 13:59:21.399+0900 I/UXT     (15215): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:59:24.902+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16951116
06-13 13:59:24.902+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 13:59:24.902+0900 E/EFL     (14656): ecore_x<14656> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16951116
06-13 13:59:24.902+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 13:59:25.083+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16951291
06-13 13:59:25.083+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 13:59:25.083+0900 E/EFL     (14656): ecore_x<14656> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16951291
06-13 13:59:25.083+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:59:25.083+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:59:25.083+0900 E/STARTER (  721): )
06-13 13:59:25.083+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:59:25.083+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:59:25.083+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:59:25.083+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:59:25.283+0900 W/STARTER (  721): hw_key.c: _homekey_timer_cb(479) > [_homekey_timer_cb:479] _homekey_timer_cb, homekey count[1], lock state[0]
06-13 13:59:25.293+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:59:25.293+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:59:25.293+0900 E/STARTER (  721): )
06-13 13:59:25.293+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:25.293+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 1167
06-13 13:59:25.293+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
06-13 13:59:25.303+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:25.303+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 13:59:25.303+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:59:25.303+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 13:59:25.303+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:59:25.313+0900 W/AUL     (  607): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1167, appid: com.samsung.homescreen
06-13 13:59:25.313+0900 W/AUL_AMD (  607): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 0, pid: 1167
06-13 13:59:25.313+0900 W/AUL_AMD (  607): amd_request.c: __send_home_launch_signal(577) > send a home launch signal
06-13 13:59:25.313+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESET State: PAUSED
06-13 13:59:25.313+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 13:59:25.313+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(1167), cmd(0)
06-13 13:59:25.313+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1167)
06-13 13:59:25.313+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 13:59:25.313+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 13:59:25.313+0900 E/STARTER (  721): dbus-util.c: starter_dbus_home_raise_signal_send(219) > [starter_dbus_home_raise_signal_send:219] Sending HOME RAISE signal, result:0
06-13 13:59:25.323+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:59:25.323+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 13:59:25.323+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 13:59:25.323+0900 W/CAPI_APPFW_APP_CONTROL( 1167): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-13 13:59:25.333+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
06-13 13:59:25.333+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(566) > [APP 1167] App already running, raise the window
06-13 13:59:25.343+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 13:59:25.343+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:59:25.343+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:59:25.343+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 13:59:25.343+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 13:59:25.363+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 13:59:25.403+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:25.403+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:25.423+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:59:25.423+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:59:25.423+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 13:59:25.423+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:59:25.423+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 13:59:25.433+0900 I/APP_CORE(14656): appcore-efl.c: __do_app(514) > [APP 14656] Event: PAUSE State: RUNNING
06-13 13:59:25.433+0900 I/CAPI_APPFW_APPLICATION(14656): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:59:25.433+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14656) status(4)
06-13 13:59:25.433+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.myfile-lite(14656)
06-13 13:59:25.433+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14656, appid: com.samsung.myfile-lite, status: bg
06-13 13:59:25.443+0900 I/TIZEN_N_SOUND_MANAGER(  910): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
06-13 13:59:25.443+0900 E/TIZEN_N_SOUND_MANAGER(  910): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:59:25.443+0900 I/TIZEN_N_SOUND_MANAGER(  910): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-13 13:59:25.443+0900 E/TIZEN_N_SOUND_MANAGER(  910): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:59:25.443+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:59:25.463+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:25.483+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:59:25.483+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:25.483+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:59:25.483+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:59:25.483+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:59:25.483+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:59:25.563+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:59:25.563+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:59:25.563+0900 I/TIZEN_N_EFL_UTIL_WINDOW(14656): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 134
06-13 13:59:25.563+0900 E/APP_CORE(14656): appcore-efl.c: _capture_and_make_file(1619) > win[3200003] widget[720] height[1280]
06-13 13:59:25.563+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:59:25.893+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16952107
06-13 13:59:25.893+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16952107
06-13 13:59:25.893+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 13:59:25.893+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 13:59:25.893+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 13:59:26.204+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:59:26.204+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:59:26.204+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:59:26.204+0900 E/STARTER (  721): )
06-13 13:59:26.204+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:59:26.204+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:59:26.204+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:59:26.214+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 13:59:26.214+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:26.224+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 13:59:26.224+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:59:26.224+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 13:59:26.224+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:59:26.244+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:26.244+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:59:26.244+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:59:26.244+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:59:26.254+0900 E/TBM     (  262): tbm_bufmgr.c: tbm_bo_export(1407) > [tbm_bo_export] : '_tbm_bo_is_valid(bo)' failed.
06-13 13:59:26.264+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 13:59:26.264+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 13:59:26.264+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 I/CAPI_APPFW_APPLICATION(14899): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:59:26.274+0900 I/CAPI_APPFW_APPLICATION(14899): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:59:26.344+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14899, appid: com.samsung.task-mgr
06-13 13:59:26.344+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:59:26.344+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14899)
06-13 13:59:26.354+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 13:59:26.394+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.404+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.424+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.444+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.454+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.474+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.494+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.494+0900 W/TASK_MGR_LITE(14899): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 13:59:26.494+0900 I/GXT_SIB (14899): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 13:59:26.544+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.554+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:26.554+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:26.564+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:59:26.564+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:59:26.564+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:59:26.564+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:59:26.574+0900 E/RUA     (14899): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 25, ncols : 5
06-13 13:59:26.574+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.574+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:26.584+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.584+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:59:26.584+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 13:59:26.584+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:26.584+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14656
06-13 13:59:26.584+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 13:59:26.594+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.604+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.654+0900 I/APP_CORE(14899): appcore-efl.c: __do_app(514) > [APP 14899] Event: RESET State: CREATED
06-13 13:59:26.654+0900 I/CAPI_APPFW_APPLICATION(14899): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 13:59:26.654+0900 E/EFL     (14899): edje<14899> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:26.654+0900 E/EFL     (14899): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:26.654+0900 E/EFL     (14899): edje<14899> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:26.654+0900 E/EFL     (14899): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:26.664+0900 W/APP_CORE(14899): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800003
06-13 13:59:26.664+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 13:59:26.764+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16952974
06-13 13:59:26.764+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16952974
06-13 13:59:26.764+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 13:59:26.764+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 13:59:26.764+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:59:26.764+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:59:26.764+0900 E/STARTER (  721): )
06-13 13:59:26.774+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:59:26.774+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:59:26.774+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:59:26.774+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:59:26.834+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14899) status(0)
06-13 13:59:26.834+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14899) status(0)
06-13 13:59:26.834+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 13:59:26.834+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:59:26.834+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 13:59:26.834+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 13:59:26.834+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 13:59:26.834+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 13:59:26.844+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14899) status(3)
06-13 13:59:26.844+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:59:26.844+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:59:26.844+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.844+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(14899)
06-13 13:59:26.844+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14899, appid: com.samsung.task-mgr, status: fg
06-13 13:59:26.854+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 13:59:26.854+0900 I/APP_CORE(14899): appcore-efl.c: __do_app(514) > [APP 14899] Event: RESUME State: CREATED
06-13 13:59:26.854+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:59:26.854+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:59:26.854+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:59:26.864+0900 I/APP_CORE(14899): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 13:59:26.864+0900 I/APP_CORE(14899): appcore-efl.c: __do_app(625) > [APP 14899] Initial Launching, call the resume_cb
06-13 13:59:26.864+0900 I/CAPI_APPFW_APPLICATION(14899): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:59:27.395+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 13:59:27.395+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 14899.
06-13 13:59:27.405+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1552
06-13 13:59:27.675+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16953881
06-13 13:59:27.765+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16953969
06-13 13:59:28.246+0900 I/UXT     (15248): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:59:28.266+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16954477
06-13 13:59:28.266+0900 E/TASK_MGR_LITE(14899): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 13:59:28.286+0900 E/TBM     (15248): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:59:28.286+0900 I/MALI    (15248): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=15248   open drm_fd=30 
06-13 13:59:28.386+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16954599
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14656
06-13 13:59:28.396+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(396) > request cmd(4) to(14656)
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 13:59:28.396+0900 I/APP_CORE(14656): appcore-efl.c: __do_app(514) > [APP 14656] Event: TERMINATE State: PAUSED
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(14656), cmd(4)
06-13 13:59:28.396+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:59:28.406+0900 I/TIZEN_N_EFL_UTIL_WINDOW(14656): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
06-13 13:59:28.406+0900 E/APP_CORE(14656): appcore-efl.c: _capture_and_make_file(1619) > win[3200003] widget[720] height[1280]
06-13 13:59:28.406+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:59:28.406+0900 E/APP_CORE(14656): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.myfile-lite]
06-13 13:59:28.416+0900 I/CAPI_APPFW_APPLICATION(14656): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:59:28.416+0900 I/CAPI_CONTENT_MEDIA_CONTENT(14656): media_content.c: media_content_disconnect(940) > [32m[14656]ref count changed to: 0
06-13 13:59:28.426+0900 E/EFL     (15248): edje<15248> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:28.426+0900 E/EFL     (15248): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:28.426+0900 E/EFL     (15248): edje<15248> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:28.426+0900 E/EFL     (15248): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:28.426+0900 E/EFL     (15248): edje<15248> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:28.426+0900 E/EFL     (15248): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:28.426+0900 E/CLOUD_CONTENT_SYNC_CLIENT(14656): cs_client.c: cloud_content_sync_folder_unset_changed_cb(3749) > [0;31m* Critical * Invalid handle[0;m
06-13 13:59:28.426+0900 E/CLOUD_CONTENT_SYNC_CLIENT(14656): cs_client.c: cloud_content_sync_content_unset_changed_cb(3662) > [0;31m* Critical * Invalid handle[0;m
06-13 13:59:28.426+0900 W/MYFILES (14656): mf-cloud-service.c: mf_cloud_content_destroy_handle(61) > handle is NULL
06-13 13:59:28.426+0900 E/MYFILES (14656): mf-cloud-operation.c: mf_cloud_operation_src_list_free(147) > [31mmore is [0][0m
06-13 13:59:28.426+0900 E/EFL     (14656): <14656> e_dbus.c:640 e_dbus_shutdown() Init count not greater than 0 in shutdown.
06-13 13:59:28.536+0900 I/MALI    (14656): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14656   close drm_fd=30 
06-13 13:59:28.786+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14656 pgid = 14656
06-13 13:59:28.786+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14656)
06-13 13:59:28.816+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:59:28.816+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:59:28.816+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:59:28.816+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14656
06-13 13:59:28.816+0900 I/Tizen::App( 1175): (243) > App[com.samsung.myfile-lite] pid[14656] terminate event is forwarded
06-13 13:59:28.816+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:59:28.816+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.myfile-lite, 14656, ]
06-13 13:59:28.816+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:59:28.816+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.myfile-lite)
06-13 13:59:28.816+0900 I/Tizen::App( 1175): (512) > Not registered pid(14656)
06-13 13:59:28.816+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.myfile-lite]
06-13 13:59:28.816+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:59:28.816+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14656
06-13 13:59:28.816+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1555
06-13 13:59:28.826+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:59:28.826+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.myfile-lite, 14656.
06-13 13:59:28.856+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16955060
06-13 13:59:28.926+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16955137
06-13 13:59:28.936+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:28.936+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:59:28.936+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:59:28.946+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:28.946+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 14899
06-13 13:59:28.956+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:59:28.956+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:28.956+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:59:28.956+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:59:28.956+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:59:28.976+0900 I/abc     (15215): abc
06-13 13:59:28.976+0900 I/CAPI_APPFW_APPLICATION(15215): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:59:28.976+0900 I/CAPI_APPFW_APPLICATION(15215): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:59:29.006+0900 E/TBM     (15215): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:59:29.057+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15215, appid: org.example.client
06-13 13:59:29.057+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:59:29.077+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15215)
06-13 13:59:29.377+0900 W/CRASH_MANAGER(15203): worker.c: worker_job(1199) > 0415215636c69149732996
